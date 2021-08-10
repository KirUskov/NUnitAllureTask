using LittleFramework.Objects.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllureTask.Steps
{
    public sealed class SearchingSteps
    {
        private readonly SearchingPagePart searchingPagePart;
        public SearchingSteps()
        {
            searchingPagePart = new SearchingPagePart();
        }

        public void TypeTextInSearchBox(string text)
        {
            searchingPagePart.AssertIsVisible();
            searchingPagePart.TypeTextInSearchingTextBox(text);
        }

        public void WhenIClickSearchButton()
        {
            searchingPagePart.AssertIsVisible();
            searchingPagePart.ClickSearchButton();
        }


    }
}
