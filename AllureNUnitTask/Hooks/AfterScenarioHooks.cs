using LittleFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AllureTask.Hooks
{
    [Binding]
    public sealed class AfterScenarioHooks
    {
        private readonly Application application;

        public AfterScenarioHooks()
        {
            application = Application.GetInstance();
        }

        [AfterScenario(Order = 0)]
        public void SetUp()
        {
            application.CloseDriver();
        }

    }
}
