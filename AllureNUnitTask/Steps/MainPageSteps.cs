using LittleFramework.Objects.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AllureTask.Steps
{
    public class MainPageSteps
    {
        public readonly MainPage mainPage;

        public MainPageSteps()
        {
            mainPage = new MainPage();
        }

        public void PageWasOpened()
        {
            mainPage.AssertIsVisible();
        }

    }
}
