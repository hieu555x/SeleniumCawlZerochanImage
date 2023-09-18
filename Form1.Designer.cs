namespace ZerochanImageSelenium
{
    partial class Begin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txbUrl = new ComboBox();
            okButton = new Button();
            exitButton = new Button();
            groupBox3 = new GroupBox();
            browserButton = new Button();
            txbBrowser = new ComboBox();
            folderBrowser = new FolderBrowserDialog();
            dataDownload = new DataGridView();
            columnNumber = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnStatus = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataDownload).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txbUrl);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 65);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập link Zerochan mà bạn muốn cawl vào đây";
            // 
            // txbUrl
            // 
            txbUrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbUrl.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txbUrl.FormattingEnabled = true;
            txbUrl.Location = new Point(6, 22);
            txbUrl.Name = "txbUrl";
            txbUrl.Size = new Size(468, 31);
            txbUrl.TabIndex = 2;
            // 
            // okButton
            // 
            okButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.Location = new Point(83, 506);
            okButton.Name = "okButton";
            okButton.Size = new Size(124, 38);
            okButton.TabIndex = 3;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(279, 506);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(124, 38);
            exitButton.TabIndex = 4;
            exitButton.Text = "Thoát";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(browserButton);
            groupBox3.Controls.Add(txbBrowser);
            groupBox3.Location = new Point(12, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(480, 65);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chọn nơi bạn muốn lưu hình ảnh";
            // 
            // browserButton
            // 
            browserButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            browserButton.Location = new Point(350, 15);
            browserButton.Name = "browserButton";
            browserButton.Size = new Size(124, 38);
            browserButton.TabIndex = 5;
            browserButton.Text = "Browser";
            browserButton.UseVisualStyleBackColor = true;
            browserButton.Click += browserButton_Click;
            // 
            // txbBrowser
            // 
            txbBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBrowser.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txbBrowser.FormattingEnabled = true;
            txbBrowser.Location = new Point(6, 22);
            txbBrowser.Name = "txbBrowser";
            txbBrowser.Size = new Size(338, 31);
            txbBrowser.TabIndex = 2;
            // 
            // dataDownload
            // 
            dataDownload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataDownload.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDownload.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDownload.Columns.AddRange(new DataGridViewColumn[] { columnNumber, columnName, columnStatus });
            dataDownload.Location = new Point(12, 154);
            dataDownload.Name = "dataDownload";
            dataDownload.RowTemplate.Height = 25;
            dataDownload.Size = new Size(480, 346);
            dataDownload.TabIndex = 6;
            // 
            // columnNumber
            // 
            columnNumber.HeaderText = "No";
            columnNumber.Name = "columnNumber";
            // 
            // columnName
            // 
            columnName.HeaderText = "Name";
            columnName.Name = "columnName";
            // 
            // columnStatus
            // 
            columnStatus.HeaderText = "Status";
            columnStatus.Name = "columnStatus";
            // 
            // Begin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 556);
            Controls.Add(dataDownload);
            Controls.Add(groupBox3);
            Controls.Add(exitButton);
            Controls.Add(okButton);
            Controls.Add(groupBox1);
            Name = "Begin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zerochan Image Cawl using Selenium";
            FormClosed += Begin_FormClosed;
            Load += Begin_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataDownload).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox txbUrl;
        private Button okButton;
        private Button exitButton;
        private GroupBox groupBox3;
        private Button browserButton;
        private ComboBox txbBrowser;
        private FolderBrowserDialog folderBrowser;
        private DataGridView dataDownload;
        private DataGridViewTextBoxColumn columnNumber;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnStatus;
    }
}