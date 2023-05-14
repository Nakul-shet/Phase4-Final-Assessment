﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPortalTests
{
    
    internal class BaseElementOrganizedTests : BaseTest
    {
        [Test]
        public void SimpleTest()
        {

            GetDriver().FindElement(By.Id("privacy")).Click();
            GetDriver().FindElement(By.Id("register")).Click();
            GetDriver().FindElement(By.Id("Name")).SendKeys("Nakul");
            GetDriver().FindElement(By.Id("UserName")).SendKeys("nakulshet");
            GetDriver().FindElement(By.Id("password")).SendKeys("N@kuL");
            GetDriver().FindElement(By.Id("Email")).SendKeys("nakulshet1@gmail.com");
            GetDriver().FindElement(By.Id("register-btn")).Click();
            Thread.Sleep(2000);
            GetDriver().FindElement(By.Id("UserName")).SendKeys("nakulshet");
            GetDriver().FindElement(By.Id("password")).SendKeys("N@kuL");
            GetDriver().FindElement(By.Id("loginbtn")).Click();
            Thread.Sleep(2000);
            GetDriver().FindElement(By.Id("avail-btn")).Click();
            Thread.Sleep(2000);
            GetDriver().FindElement(By.Id("view-btn")).Click();
            Thread.Sleep(3000);
            GetDriver().FindElement(By.Id("cart-btn")).Click();
            Thread.Sleep(2000);
            GetDriver().FindElement(By.Id("check-btn")).Click();
            Thread.Sleep(2000);
            GetDriver().FindElement(By.Id("UserName")).SendKeys("Nakul");
            GetDriver().FindElement(By.Id("Email")).SendKeys("nakulnshet1@gmail.com");
            GetDriver().FindElement(By.Id("Phone")).SendKeys("8050558156");
            GetDriver().FindElement(By.Id("Addre")).SendKeys("Mangalore");
            Thread.Sleep(2000);
            var countryDropDown = GetDriver().FindElement(By.Id("country"));
            var countrySelectElement = new SelectElement(countryDropDown);
            countrySelectElement.SelectByText("India");
            Thread.Sleep(2000);
            var stateDropDown = GetDriver().FindElement(By.Id("state"));
            var stateSelectElement = new SelectElement(stateDropDown);
            stateSelectElement.SelectByText("Andhra Pradesh");
            GetDriver().FindElement(By.Id("Zip")).SendKeys("520007");
            /*GetDriver().FindElement(By.Id("same-address")).Click();
            GetDriver().FindElement(By.Id("save-info")).Click();*/
            Thread.Sleep(2000);
            var checkbox1 = GetDriver().FindElement(By.Id("same-address"));
            checkbox1.Click();
            var checkbox2 = GetDriver().FindElement(By.Id("save-info"));
            checkbox2.Click();
            GetDriver().FindElement(By.Id("checkout-btn")).Click();
            Thread.Sleep(2000);
            var paymentDropDown = GetDriver().FindElement(By.Id("select"));
            var paymentSelectElement = new SelectElement(paymentDropDown);
            paymentSelectElement.SelectByText("Credit Card");
            GetDriver().FindElement(By.Id("payment")).Click();
            Thread.Sleep(2000);
            GetDriver().FindElement(By.Id("logout-btn")).Click();
            Thread.Sleep(2000);




        }

       

      
    }
}