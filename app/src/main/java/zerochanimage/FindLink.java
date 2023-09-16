
package zerochanimage;

import io.github.bonigarcia.wdm.WebDriverManager;
import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.edge.EdgeOptions;


import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.TimeUnit;

public class FindLink {
    EdgeOptions options;
    WebDriver driver;

    FindLink() {
        WebDriverManager.edgedriver().setup();
        options = new EdgeOptions();
        options.addArguments("--remote-allow-origins=*");
        //options.setHeadless(true);

        driver = new EdgeDriver(options);

        driver.manage().window().minimize();

    }

    public void Login() {

        driver.get("https://www.zerochan.net/login");
        WebElement login = driver.findElement(By.name("name"));
        WebElement password = driver.findElement(By.name("password"));
        WebElement button = driver.findElement(By.name("login"));;


        login.sendKeys("hieu555x");
        password.sendKeys("Trung_hieu9@");
        button.click();

        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
        //#endregion
    }

    public ArrayList<String> getAllImageLink(String Url) {
        ArrayList<String> listLink = new ArrayList<>();

        driver.get(Url);

        Document document = Jsoup.parse(driver.getPageSource());

        Element ulElement = document.getElementById("thumbs2");

        List<Element> listElement = ulElement.getElementsByTag("li");

        for (Element e : listElement) {

            Elements aElement = e.getElementsByTag("a");
            for (Element element : aElement) {
                if (element.absUrl("href").contains("static")) {
                    listLink.add(element.absUrl("href"));

                    //System.out.println(element.absUrl("href"));
                }
            }

        }
        return listLink;
    }

    public int getPageIndex(String Url) {
        driver.get(Url);
        WebElement pageIndex = driver.findElement(By.className("pagination"));
        String s = pageIndex.getText();
        int Index = 0;
        for (int i = 0; i < s.split(" ").length; i++) {
            try {
                Index = Integer.valueOf(s.split(" ")[i]);
            } catch (Exception ex) {
                Index = Index;
            }
        }
        return Index;
    }

    public void quitChrome() {
        driver.quit();
    }
}
