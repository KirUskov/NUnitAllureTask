using LittleFramework.Objects.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Autotests.Steps
{
    public sealed class SearchingResultsPageSteps
    {
        public readonly SearchingResultsPage searchingResultsPage;
        
        public SearchingResultsPageSteps()
        {
            searchingResultsPage = new SearchingResultsPage();
        }

        public void CheckResultPageWithInfotable(string title)
        {
            searchingResultsPage.AssertIsVisible();
            var isTablePresent = searchingResultsPage.IsTableWithTitlePresent(title);
            Assert.IsTrue(isTablePresent, $"Table with title '{title}' should exist on the searching result page, but it doesn't.");
        }

    }
}
