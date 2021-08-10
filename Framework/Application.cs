using LittleFramework.Elements;
using LittleFramework.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework
{
    public class Application
    {
        public IWebDriver Driver;

        private static Application application;

        public Configuration Configuration
        {
            get
            {
                return new Configuration();
            }
        }

        public TextBox TextBox(By locator)
        {
            return new TextBox(application, locator);
        }

        private Application()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        public static Application GetInstance()
        {
            if(application == null)
            {
                application = new Application();
            }
            return application;
        }

        public void CloseDriver()
        {
            Driver.Quit();
            Driver.Dispose();
            application = null;
        }

    }
}
