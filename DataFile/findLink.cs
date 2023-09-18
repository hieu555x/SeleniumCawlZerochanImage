//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Edge;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;

//namespace ZerochanImageSelenium.DataFile
//{
//    internal class findLink
//    {
//        EdgeOptions options;
//        WebDriver driver;

//        public findLink()
//        {
//            options = new EdgeOptions();
//            options.AddArgument("--remote-allow-origins=*");

//            driver = new EdgeDriver(options);

//            //driver.Manage().Window.Minimize();
//        }

//        public void Login()
//        {
//            driver.Navigate().GoToUrl("https://www.zerochan.net/login");
//            WebElement login = (WebElement)driver.FindElement(By.Name("name"));
//            WebElement password = (WebElement)driver.FindElement(By.Name("password"));
//            WebElement button = (WebElement)driver.FindElement(By.Name("login"));

//            login.SendKeys("hieu555x");
//            password.SendKeys("Trung_hieu9@");
//            button.Click();

//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
//        }

//        public ArrayList getAllImageLink(string url)
//        {
//            ArrayList listLink = new ArrayList();

//            driver.Navigate().GoToUrl(url);



//            return listLink;
//        }
//    }
//}
