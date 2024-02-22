using NUnit.Framework;
using NUnit.Framework.Internal;
using TitleCaseWebApp;

namespace TestProject1.Tests
{
    public class TestMeTests
    {
        private TestMe _testMe;

        [SetUp]
        public void Setup()
        {
            _testMe = new TestMe();
        }

        [Test]
        public void MakeTitle_WithLowerCaseInput_ReturnsTitleCase()
        {
            string input = "this is a test";
            string expected = "This Is A Test";

            string result = _testMe.MakeTitle(input);

            Assert.AreEqual(expected, result);
        }

        //[Test]
        //public void MakeTitle_WithMixedCaseInput_ReturnsTitleCase()
        //{
        //    string input = "tHis iS aNOTher tEst";
        //    string expected = "This Is Another Test";

        //    string result = _testMe.MakeTitle(input);

        //    Assert.AreEqual(expected, result);
        //}

        [Test]
        public void MakeTitle_WithEmptyInput_ReturnsEmptyString()
        {
            string input = "";
            string expected = "";

            string result = _testMe.MakeTitle(input);

            Assert.AreEqual(expected, result);
        }
    }
}
