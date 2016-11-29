﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTraining.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        //Page objects POM
        [FindsBy(How = How.Id, Using = "loginform")]
        private IWebElement _loginForm;

        [FindsBy(How = How.Id, Using = "welcome")]
        private IWebElement _dashboardScreen;


        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public string LoginForm => _loginForm.Text;
        public string DashboardScreen => _dashboardScreen.Text;
    }
}
