using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace FlipcartAzures.Pages
{
   public class Login
    {
        
        public IWebDriver driver;
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _1dBPDZ']")]
        IWebElement phone;

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _3v41xv _1dBPDZ']")]
        IWebElement pass;

        [FindsBy(How = How.XPath, Using = "//button[@class='_2AkmmA _1LctnI _7UHT_c']//span[contains(text(),'Login')]")]
        IWebElement LoginButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'My Account')]")]
        IWebElement validation;

        public void LoginPage(string Email,string Password)
        {
            Thread.Sleep(2000);
            phone.SendKeys(Email);
            Thread.Sleep(2000);
            pass.SendKeys(Password);
            Thread.Sleep(2000);
            LoginButton.Click();
            Thread.Sleep(2000);
        }

        public string Validate()
        {
            return validation.Text;
        }
    }
}
   
