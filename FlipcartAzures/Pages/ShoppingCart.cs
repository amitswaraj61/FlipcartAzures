using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlipcartAzures.Pages
{
   public class ShoppingCart
    {

        IWebDriver driver;

        public ShoppingCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/button[1]")]
        public IWebElement AddCart;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Place Order')]")]
        public IWebElement PlaceOrder;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'CONTINUE')]")]
        public IWebElement Continue;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'UPI (PhonePe / Paytm / Google Pay)')]")]
        public IWebElement validation;


        public void AddToCart()
        {
            AddCart.Click();
            Thread.Sleep(3000);
            PlaceOrder.Click();
            Thread.Sleep(3000);
            Continue.Click();
            Thread.Sleep(3000);
        }

        public string Validate()
        {
            return validation.Text;
        }
    }
}
 