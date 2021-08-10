using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AllureNUnitTask.Tests
{
    public class BaseTest
    {
        private readonly Navigation navigation;

        public BaseTest()
        {
            navigation = new Navigation();
        }

        [SetUp]
        public void SetUp()
        {
            navigation.ToBaseUrl();
        }
    }
}
