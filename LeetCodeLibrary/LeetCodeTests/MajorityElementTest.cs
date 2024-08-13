using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeTests
{
    [TestFixture]
    public class MajorityElementTest
    {
        private MajorityElement _majorityElement;

        [SetUp]
        public void SetUp()
        {
            _majorityElement = new MajorityElement();
        }
        [Test]
        public void Test()
        {
            //Arrange
            int[] nums = { 42 }; 

            //Act
            int result = _majorityElement.MajorityElements(nums);

            //Assert
            Assert.AreEqual(42, result);
        }
        [Test]
        public void Test2()
        {
            //Arrange
            int[] nums = { 2, 2, 3, 2, 4, 2, 5 };

            //Act
            int result = _majorityElement.MajorityElements(nums);

            //Assert
            Assert.AreEqual(2, result);
        }

    }
}
