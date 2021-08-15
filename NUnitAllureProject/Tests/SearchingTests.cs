using AllureTask.Steps;
using Autotests.Steps;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnitAllureProject.Tests.Steps;
using System.Collections.Generic;

namespace NUnitAllureProject.Tests
{
    [AllureNUnit]
    public class SearchingTests : Hooks
    {
        private MainPageSteps mainPageSteps;
        private SearchingSteps searchingSteps;
        private SearchingResultsPageSteps searchingResultsPageSteps;

        public SearchingTests() : base()
        {
        }

        [SetUp]
        public void InitPages()
        {
            mainPageSteps = new MainPageSteps();
            searchingSteps = new SearchingSteps();
            searchingResultsPageSteps = new SearchingResultsPageSteps();
        }


        private static IEnumerable<TestCaseData> AddQueryResultData()
        {
            yield return new TestCaseData("Google", "Google");
            yield return new TestCaseData("����", "����");
            yield return new TestCaseData("������", "������");
        }

        [Test, TestCaseSource("AddQueryResultData")]
        [Description("Is Infotable displayed after searching item")]
        [AllureTag("Regression")]
        [AllureFeature("Searching")]
        [AllureSuite("SearchingPage")]
        public void CheckResultInfotableWasOpeneForSearchingItem(string query, string title)
        {
            mainPageSteps.PageWasOpened();
            searchingSteps.SearchItem(query);
            searchingResultsPageSteps.CheckResultPageWithInfotable(title);
        }
    }
}