using LibGit2Sharp;
using System.Diagnostics;
using System.Text.Json;
using ZerochanImageSelenium.Data;
using ZerochanImageSelenium.DataFile;
using System.Management;
using System.Net;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Security.Policy;

namespace ZerochanImageSelenium
{
    public partial class Begin : Form
    {
        System.Diagnostics.Process cmd;
        List<ListLink> items = new List<ListLink>();
        public Begin()
        {
            InitializeComponent();
        }

        private async void Begin_Load(object sender, EventArgs e)
        {
            cmd = new Process();

            string path = Environment.CurrentDirectory + @"\HistoryInput.txt";
            string linkHistoryPath = Environment.CurrentDirectory + @"\HistoryLink.txt";

            History history = new History(path);
            History linkHistory = new History(linkHistoryPath);

            for (int i = 0; i < history.readFile(path).Length; i++)
            {
                txbUrl.Items.Add(history.readFile(path)[i]);
            }

            for (int i = 0; i < linkHistory.readFile(linkHistoryPath).Length; i++)
            {
                txbBrowser.Items.Add(linkHistory.readFile(linkHistoryPath)[i]);
            }

            HttpClient client = new HttpClient();


        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowser.ShowDialog();
            if (result.ToString() == "OK")
            {
                txbBrowser.Text = folderBrowser.SelectedPath;
            }
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            if (items != null||items.Count>=0)
            {
                try
                {
                    items.Clear();
                }
                catch (Exception ex)
                {

                }
            }

            if (txbUrl.Text == "" || txbUrl.Text == null || String.IsNullOrEmpty(txbBrowser.Text))
            {
                MessageBox.Show("Trường này không được để trống vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    HttpClient client = new HttpClient();
                    HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:8080/");
                }
                catch (Exception ex)
                {
                    beginSelenium();
                }

                //if (responseMessage != null && responseMessage.IsSuccessStatusCode)
                //{
                //    MessageBox.Show("Chương trình đang tiến hành xử lý vui lòng chờ trong giây lát", "Thông báo");
                //    //startGetData("http://localhost:8080/links?links=" + txbUrl.Text);
                //}
                //else
                //{
                //    beginSelenium();
                //}

                startGetData("http://localhost:8080/links?links=" + txbUrl.Text);

            }

        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                KillProcessAndChildren(cmd.Id);
            }
            catch (Exception ex)
            {

            }
            Application.Exit();
        }

        public void KillProcessAndChildren(int pid)
        {
            using (var searcher = new ManagementObjectSearcher
                ("Select * From Win32_Process Where ParentProcessID=" + pid))
            {
                var moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                }
                try
                {
                    var proc = Process.GetProcessById(pid);
                    proc.Kill();
                }
                catch (Exception e)
                {
                    // Process already exited.
                }
            }
        }

        private void startGetData(string url)
        {
            if (items.Count > 0)
            {
                for(int i=0;i<items.Count; i++)
                {
                    items.RemoveAt(i);
                }
            }
            HttpWebRequest webRequest = WebRequest.Create(string.Format(url)) as HttpWebRequest;

            webRequest.Method = "GET";

            HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse;

            Console.WriteLine(webResponse.StatusCode);
            Console.WriteLine(webResponse.Server);

            string jsonString;
            using (Stream stream = webResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            items = JsonConvert.DeserializeObject<List<ListLink>>(jsonString);

            DialogResult result = MessageBox.Show("Đã tìm được " + items.Count.ToString() + " hình ảnh. Bạn có muốn download hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                using (WebClient client = new WebClient())
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (!File.Exists(txbBrowser.Text + @"\" + items.ElementAt(i).fileName))
                        {
                            dataDownload.Rows.Add(i, items.ElementAt(i).fileName,"Downloaded");
                            client.DownloadFileAsync(new Uri(items.ElementAt(i).urlFile), txbBrowser.Text + @"\" + items.ElementAt(i).fileName);
                            while (client.IsBusy)
                            {

                            }
                        }
                        else
                        {
                            dataDownload.Rows.Add(i, items.ElementAt(i).fileName, "Exists");
                        }
                    }
                }
            }
            MessageBox.Show("Finish", "Finish");
        }

        private void Begin_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                KillProcessAndChildren(cmd.Id);
            }
            catch (Exception ex)
            {

            }
        }

        private void beginSelenium()
        {

            string command = Environment.CurrentDirectory + @"\JavaAPI";
            string cdCommand = "cd " + command;

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            using (StreamWriter sw = cmd.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(command.Split('\\')[0] + "\\");
                    sw.WriteLine(cdCommand);
                    sw.WriteLine("gradlew bootRun");
                    sw.WriteLine("pause");
                    sw.WriteLine("exit");
                }

            }
            System.Threading.Thread.Sleep(17000);
        }
    }
}