using FlipcartAzures.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipcartAzures.FlipcartTest
{
   public class Test : Base
    {
        [Test, Order(1)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.LoginPage(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["password"]);
            Assert.AreEqual("My Account", login.Validate());
        }

        [Test, Order(2)]
        public void SearchProduct()
        {
            Home home = new Home(driver);
            home.SearchProduct();
            Assert.AreEqual("BUY NOW", home.Validate());


        }
    }
}
