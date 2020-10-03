using FlipcartAzures.Pages;
using NUnit.Framework;
using System.Configuration;

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

        [Test, Order(3)]
        public void ShoppingCartTest()
        {
            ShoppingCart cart = new ShoppingCart(driver);
            cart.AddToCart();
            Assert.AreEqual("UPI (PhonePe / Paytm / Google Pay)", cart.Validate());
        }

        [Test, Order(4)]
        public void LogoutTest()
        {
            Logout logout = new Logout(driver);
            logout.LogoutFromFlipkart();
        }
    }
}
