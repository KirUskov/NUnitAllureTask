using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Base
{
    public class Navigation
    {
        private readonly Application app;

        public Navigation()
        {
            app = Application.GetInstance();
        }

        public void ToBaseUrl()
        {
            app.Driver.Navigate().GoToUrl(app.Configuration.GetUrl());
        }
    }
}
