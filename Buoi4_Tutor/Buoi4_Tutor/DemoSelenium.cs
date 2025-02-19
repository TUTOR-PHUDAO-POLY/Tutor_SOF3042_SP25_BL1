using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buoi4_Tutor
{
    [TestClass]
    public class DemoSelenium
    {
        [TestMethod]
        public void TestDemoSelenium()
        {
            // chat bot
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalOption("useAutomationExtension", false);

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            // Y1: Mo truyen duyet chorme => google.com 
            // B1: Lay driver cua gg chrome 
            //ChromeDriver driver = new ChromeDriver();
            // B2: Di chuyen toi trang can hien thi 
            driver.Navigate().GoToUrl("https://www.google.com/");
            // Co the cho dung lai vai s cho nhin => 1s = 1000 ms
            Thread.Sleep(2000);
            // Y2: Tim kiem vao o tim kiem chu udemy roi bam enter 
            // B3: Lay duoc o tim kiem tren giao dien:  Tim kiem By theo XPath, id, class, CSSSelector....
            //IWebElement searchValueInput = driver.FindElement(By.XPath("//*[@id=\"APjFqb\"]"));
            driver.FindElement(By.XPath("//*[@id=\"APjFqb\"]")).SendKeys("Udemy" + Keys.Enter);
            // B4: Dien gia tri vao o input: Click -> button, dien gia tri vao o input: sendkeys
            //searchValueInput.SendKeys("Udemy"+Keys.Enter);
            // Y3: Tim kiem trang web v click de hien thi
            // B5 Tim kiem trang web 
            driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div/div/div/div[1]/div/span/a/h3")).Click();
            //*[@id="rso"]/div[1]/div/div/div/div/div/div/div/div/div[1]/div/span/a/h3
            //*[@id="rso"]/div[1]/div/div/div/div/div/div/div/div[1]/div/span/a/h3
            // B6: Cho trinh duyet dung lai vai s
            Thread.Sleep(3000);
            // Giai phong tai nguyen 
            driver.Close();
        }
    }
}
