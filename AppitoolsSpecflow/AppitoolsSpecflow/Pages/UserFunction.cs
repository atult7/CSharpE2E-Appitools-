using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AppitoolsSpecflow.Pages
{
    class UserFunction
    {
        public IWebDriver WebDriver { get; }
        public UserFunction(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement txtemail => WebDriver.FindElement(By.XPath("//*[@id='email']"));
        public IWebElement txtpwd => WebDriver.FindElement(By.XPath("//*[@id='password']"));
        public IWebElement txtbtnsig => WebDriver.FindElement(By.XPath("//*[@class='btn btn-call-to-action']"));

        public IWebElement txtoptf => WebDriver.FindElement(By.XPath("//*[@id='page-content']/div[1]/div[3]/div/div[2]/div/div/button[1]"));
        public IWebElement txtopts => WebDriver.FindElement(By.XPath("//*[@id='page-content']/div[1]/div[3]/div/div[2]/div/div/button[2]"));
        public IWebElement txtoptt => WebDriver.FindElement(By.XPath("//*[@id='page-content']/div[1]/div[3]/div/div[2]/div/div/button[3]"));

        public IWebElement txtmouse=>WebDriver.FindElement(By.XPath("//*[@id='wrapper']/div/div[1]/div[4]/div/div/div/div[2]/button"));
        
        public IWebElement txtlgout => WebDriver.FindElement(By.XPath("//*[@id=\'dropdown-1\']/div/button[4]"));

        //Scenario1

        public void Getmail()
        {
            txtemail.SendKeys("sender01togo@outlook.com");
        }
        public void Getpwd()
        {
            txtpwd.SendKeys("Sender@4321");
        }
        public void Getsignin()
        {
            txtbtnsig.Click();
            
        }
        public void Getoptf()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Console.WriteLine(txtoptf.Enabled);
        }
        public void Getopts()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Console.WriteLine(txtopts.Enabled);
        }
        public void Getoptt()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Console.WriteLine(txtoptt.Enabled);
        }
        public void Getmove()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            txtmouse.Click();
        }
        public void Getlgout()
        {
            Thread.Sleep(3000);
            txtlgout.Click();
            WebDriver.Close();
        }

        //Scenario2

        public IWebElement txtprod => WebDriver.FindElement(By.XPath("//*[@id='menu-item-50']/a"));
        public IWebElement txtusecase => WebDriver.FindElement(By.XPath("//*[@id='menu-item-54']/a"));
        public IWebElement txtchatbot => WebDriver.FindElement(By.XPath("//*[@id='intercom-container']/div/iframe"));
        public IWebElement txtclsbot => WebDriver.FindElement(By.XPath("//*[@id='intercom-container']/div/iframe"));
        public IWebElement txtplay => WebDriver.FindElement(By.XPath("//button[@class='play']"));
        
        

        public void Getprod()
        {
            Console.WriteLine(txtprod.Text);
        }
        public void Getusecase()
        {
            Console.WriteLine(txtusecase.Text);
            
        }
        public void Getchatbot()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            txtchatbot.Click();
        }
        public void Getclsbot()
        {
            Thread.Sleep(2000);
            txtclsbot.Click();
        }
        public void Getplay()
        {
            
            IJavaScriptExecutor executor = (IJavaScriptExecutor)WebDriver;
            executor.ExecuteScript("window.scrollTo(0,1200)");
            executor.ExecuteScript("arguments[0].click();", txtplay);
             
        }
        
    




    }
}
