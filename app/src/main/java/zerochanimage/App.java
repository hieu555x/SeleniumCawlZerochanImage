package zerochanimage;

import java.io.File;
import java.io.IOException;
import java.time.LocalDate;
import java.util.ArrayList;

public class App {
    public static void main(String[] args) {
        while (!ifError()) {
            System.out.println("Try Again...");
            System.out.println("Try Again...");
            System.out.println("Try Again...");
        }
    }

    public static boolean ifError() {
        try {
            thucThi();
            return true;
        } catch (Exception ex) {
            return false;
        }
    }

    public static void thucThi() throws IOException {
        FindLink f = new FindLink();

        try {

            ArrayList<String> listLink = new ArrayList<>();
            f.Login();
            int page = f.getPageIndex("https://www.zerochan.net/Kamisato+Ayaka?s=id");

            for (int j = 0; j < page - 1; j++) {
                System.out.println("Page " + (j + 1) + ": \n");
                listLink = f.getAllImageLink("https://www.zerochan.net/Kamisato+Ayaka?s=id&p=" + (j + 1));
                DownloadImage d = new DownloadImage();
                int i = 0;
                for (String s : listLink) {
                    i++;
                    System.out.println(i + ". Link Process: " + s);
                    String fileName = s.split("/")[3];
                    if (new checkExists().check("E:\\Picture\\MyWaifu\\", fileName)) {
                        System.out.println("Exists: " + s);
                    } else {
                        String now = LocalDate.now().toString();
                        File dateFolder = new File("E:\\Picture\\MyWaifu\\Cusion\\" + now);
                        if (!dateFolder.exists() || !dateFolder.isDirectory()) {
                            dateFolder.mkdir();
                        }
                        d.saveImage(s, dateFolder + "\\" + fileName);
                        // System.out.println(s.split("/")[3]);
                        System.out.println("Finish: " + s);
                    }
                }
            }
        } catch (Exception ex) {

        }
        f.quitChrome();
        System.out.println("Finish");
    }
}
