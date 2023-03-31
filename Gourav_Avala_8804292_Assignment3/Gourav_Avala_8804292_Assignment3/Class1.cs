﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class ZeroAccidentsTest1Test
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    private string baseURL = "http://localhost/prog2070a03/prog2070a03/getQuote.html";
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void zero_Accidents_Test1()
    {
        //ARRANGE
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(925, 816);

        //ACT
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Gourav");
        driver.FindElement(By.Id("lastName")).SendKeys("Avala");
        driver.FindElement(By.Id("address")).SendKeys("749 Lawrence Street");
        driver.FindElement(By.Id("city")).SendKeys("Cambridge");
        driver.FindElement(By.Id("postalCode")).SendKeys("N3G 0A8");
        driver.FindElement(By.Id("phone")).SendKeys("518-718-4902");
        driver.FindElement(By.Id("email")).SendKeys("gouravawala2003@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();


        //ASSERT
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2500"));
        }
    }


    [Test]
    public void four_Accidents_Test2()
    {
        //ARRANGE
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(925, 816);

        //ACT
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Gourav");
        driver.FindElement(By.Id("lastName")).SendKeys("Avala");
        driver.FindElement(By.Id("address")).SendKeys("749 Lawrence Street");
        driver.FindElement(By.Id("city")).SendKeys("Cambridge");
        driver.FindElement(By.Id("postalCode")).SendKeys("N3G 0A8");
        driver.FindElement(By.Id("phone")).SendKeys("518-718-4902");
        driver.FindElement(By.Id("email")).SendKeys("gouravawala2003@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();


        //ASSERT
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }

    [Test]
    public void two_Accidents_age35_Test3()
    {
        //ARRANGE
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(925, 816);

        //ACT
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Gourav");
        driver.FindElement(By.Id("lastName")).SendKeys("Avala");
        driver.FindElement(By.Id("address")).SendKeys("749 Lawrence Street");
        driver.FindElement(By.Id("city")).SendKeys("Cambridge");
        driver.FindElement(By.Id("postalCode")).SendKeys("N3G 0A8");
        driver.FindElement(By.Id("phone")).SendKeys("518-718-4902");
        driver.FindElement(By.Id("email")).SendKeys("gouravawala2003@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();


        //ASSERT
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$1350"));
        }
    }


    [Test]
    public void zero_Accidents_age27_Test4()
    {
        //ARRANGE
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(925, 816);

        //ACT
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Gourav");
        driver.FindElement(By.Id("lastName")).SendKeys("Avala");
        driver.FindElement(By.Id("address")).SendKeys("749 Lawrence Street");
        driver.FindElement(By.Id("city")).SendKeys("Cambridge");
        driver.FindElement(By.Id("postalCode")).SendKeys("N3G 0A8");
        driver.FindElement(By.Id("phone")).SendKeys("518-718-4902");
        driver.FindElement(By.Id("email")).SendKeys("gouravawala2003@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();


        //ASSERT
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2500"));
        }
    }

    [Test]
    public void zero_Accidents_age28_Test5()
    {
        //ARRANGE
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(925, 816);

        //ACT
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Gourav");
        driver.FindElement(By.Id("lastName")).SendKeys("Avala");
        driver.FindElement(By.Id("address")).SendKeys("749 Lawrence Street");
        driver.FindElement(By.Id("city")).SendKeys("Cambridge");
        driver.FindElement(By.Id("postalCode")).SendKeys("N3G 0A8");
        driver.FindElement(By.Id("phone")).SendKeys("518-718-4902");
        driver.FindElement(By.Id("email")).SendKeys("gouravawala2003@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();


        //ASSERT
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2500"));
        }
    }


    [Test]
    public void one_Accidents_age35_experience17_Test6()
    {
        //ARRANGE
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(925, 816);

        //ACT
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Gourav");
        driver.FindElement(By.Id("lastName")).SendKeys("Avala");
        driver.FindElement(By.Id("address")).SendKeys("749 Lawrence Street");
        driver.FindElement(By.Id("city")).SendKeys("Cambridge");
        driver.FindElement(By.Id("postalCode")).SendKeys("N3G 0A8");
        driver.FindElement(By.Id("phone")).SendKeys("518-718-4902");
        driver.FindElement(By.Id("email")).SendKeys("gouravawala2003@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();


        //ASSERT
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$1350"));
        }
    }

    [Test]
    public void omit_age_experience5_Test7()
    {
        //ARRANGE
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(925, 816);

        //ACT
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Gourav");
        driver.FindElement(By.Id("lastName")).SendKeys("Avala");
        driver.FindElement(By.Id("address")).SendKeys("749 Lawrence Street");
        driver.FindElement(By.Id("city")).SendKeys("Cambridge");
        driver.FindElement(By.Id("postalCode")).SendKeys("N3G 0A8");
        driver.FindElement(By.Id("phone")).SendKeys("518-718-4902");
        driver.FindElement(By.Id("email")).SendKeys("gouravawala2003@gmail.com");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();


        //ASSERT
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo(string.Empty));
        }
    }


    [Test]
    public void omit_accidents_experience8_age37_Test8()
    {
        //ARRANGE
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(925, 816);

        //ACT
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Gourav");
        driver.FindElement(By.Id("lastName")).SendKeys("Avala");
        driver.FindElement(By.Id("address")).SendKeys("749 Lawrence Street");
        driver.FindElement(By.Id("city")).SendKeys("Cambridge");
        driver.FindElement(By.Id("postalCode")).SendKeys("N3G 0A8");
        driver.FindElement(By.Id("phone")).SendKeys("518-718-4902");
        driver.FindElement(By.Id("email")).SendKeys("gouravawala2003@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).SendKeys("8");
        driver.FindElement(By.Id("btnSubmit")).Click();


        //ASSERT
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo(string.Empty));
        }
    }

    [Test]
    public void omit_experience_zero_Accidents_age45_Test9()
    {
        //ARRANGE
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(925, 816);

        //ACT
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Gourav");
        driver.FindElement(By.Id("lastName")).SendKeys("Avala");
        driver.FindElement(By.Id("address")).SendKeys("749 Lawrence Street");
        driver.FindElement(By.Id("city")).SendKeys("Cambridge");
        driver.FindElement(By.Id("postalCode")).SendKeys("N3G 0A8");
        driver.FindElement(By.Id("phone")).SendKeys("518-718-4902");
        driver.FindElement(By.Id("email")).SendKeys("gouravawala2003@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();


        //ASSERT
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo(string.Empty));
        }
    }


}