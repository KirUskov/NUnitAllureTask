using LittleFramework.Objects.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AllureTask.Hooks
{
    [Binding]
    public sealed class BeforeScenarioHooks
    {
        private readonly Navigation navigation;

        public BeforeScenarioHooks()
        {
            navigation = new Navigation();
        }

        [BeforeScenario(Order = 0)]
        public void SetUp()
        { 
            navigation.ToBaseUrl();
        }
    }
}
