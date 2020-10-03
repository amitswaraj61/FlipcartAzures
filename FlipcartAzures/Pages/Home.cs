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
   public class Home
    {
        IWebDriver driver;

        public Home(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search for products, brands and more']")]
        public IWebElement Search;
        [FindsBy(How = How.XPath, Using = "//button[@class='vh79eN']//*[local-name()='svg']")]
        public IWebElement SearchButton;
        [FindsBy(How = How.CssSelector, Using = "div.t-0M7P._2doH3V div._3e7xtJ div._1HmYoV.hCUpcT:nth-child(1) div._1HmYoV._35HD7C:nth-child(2) div.bhgxx2.col-12-12:nth-child(2) div._3O0U0u > div:nth-child(1)")]
        public IWebElement ClickOnProduct;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[2]/form[1]/button[1]")]
        public IWebElement validation;

        public void SearchProduct()
        {
            Search.Click();
            Thread.Sleep(2000);
            Search.SendKeys("electronics");
            Thread.Sleep(3000);
            SearchButton.Click();
            Thread.Sleep(3000);
            ClickOnProduct.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(4000);
        }

        public string Validate()
        {
            return validation.Text;
        }
    }
}

