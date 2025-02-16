using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buoi3_Tutor
{
    [TestClass]
    public class DemoSelenium
    {

        [TestMethod]
        public void TestWebsiteDemo()
        {
            // chat bot
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalOption("useAutomationExtension", false);

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();

            //ChromeDriver driver = new ChromeDriver();
            // Dung no de chuyen toi trang gg 
            driver.Navigate().GoToUrl("https://google.com/");
            // Cho dung 2 s 
            Thread.Sleep(2000); // 1s -> 1000ms 
            // de tim kiem gg tren gg thi dung xpath: hoac co the By theo id,class...
            IWebElement searchInput = driver.FindElement(By.XPath("//*[@id=\"APjFqb\"]"));
            // Gui du lieu di => sendkey. Co rat nhieu cach khac co the la click...
            searchInput.SendKeys("Udemy" + Keys.Enter);
            // Chờ tối đa 10 giây để phần tử xuất hiện
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                IWebElement element = wait.Until(
                    d => d.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div/div/div/div[1]/div/span/a/h3"))
                );
             element.Click();
                // De khoang 5s
                Thread.Sleep(5000);
                driver.Close();
                Console.WriteLine("Website close");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("❌ Không tìm thấy phần tử.");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
