using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlipcartAzures.Pages
{
    public class Logout
    {
        IWebDriver driver;

        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/a[1]/img[1]")]
        public IWebElement Flipkart;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'My Account')]")]
        public IWebElement MyAccount;

        [FindsBy(How = How.XPath, Using = "//body//div[@id='container']//div//div//div//div//div//li[10]//a[1]")]
        public IWebElement LogoutButton;

       public void LogoutFromFlipkart()
        {
            Flipkart.Click();
            Thread.Sleep(3000);
            Actions action = new Actions(driver);
            action.MoveToElement(MyAccount).Build().Perform();
            Thread.Sleep(3000);
            LogoutButton.Click();
            Thread.Sleep(3000);
        }
    }
}
