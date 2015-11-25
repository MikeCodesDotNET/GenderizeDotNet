using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            var client = new GenderizeDotNet.Client();
            var result = client.GenderizeSingleName("Jayme").Result;

            Assert.IsTrue(result.Gender == GenderizeDotNet.Models.Gender.Female);
        }
    }
}

