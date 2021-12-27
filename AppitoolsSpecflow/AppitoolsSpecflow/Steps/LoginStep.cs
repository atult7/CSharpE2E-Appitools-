using AppitoolsSpecflow.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace AppitoolsSpecflow.Steps
{
    [Binding]
    public sealed class LoginStep
    {
        
        UserFunction userFunction = null;
        
        [Given(@"opens the application")]
        public void GivenOpensTheApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://auth.applitools.com/users/login");
            webDriver.Manage().Window.Maximize();
            userFunction = new UserFunction(webDriver);
        }

        [Given(@"Enter Email and password")]
        public void GivenEnterEmailAndPassword()
        {
            userFunction.Getmail();
            userFunction.Getpwd();
            
        }

        [Given(@"Clicks Signin")]
        public void GivenClicksSignin()
        {
            userFunction.Getsignin();
            
        }

        [When(@"Check user functionality")]
        public void WhenCheckUserFunctionality()
        {
            userFunction.Getoptf();
            userFunction.Getopts();
            userFunction.Getoptt();
            userFunction.Getmove();
            userFunction.Getlgout();
            
        }


        //Website feature steps


        [Given(@"user opens the application")]
        public void GivenUserOpensTheApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://applitools.com/");
            webDriver.Manage().Window.Maximize();
            userFunction = new UserFunction(webDriver);

        }

        [Given(@"user check the feature")]
        public void GivenUserCheckTheFeature()
        {
            userFunction.Getprod();
            userFunction.Getusecase();
        }

        [When(@"user tries to open chatbot")]
        public void WhenUserTriesToOpenChatbot()
        {
            userFunction.Getchatbot();
            userFunction.Getclsbot();
            
        }

        [Then(@"User tries to play video")]
        public void ThenUserTriesToPlayVideo()
        {
            userFunction.Getplay();
            
        }





    }
}
