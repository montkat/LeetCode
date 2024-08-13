﻿using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeTests
{
    [TestFixture]
    public class RemoveElementTest
    {
        [Test]
        public void Setup()
        {
            //Arrange
            var solution = new RemoveElement();
            int[] nums1 = { 3, 2, 2, 3 };
            int val1 = 3;
            int[] expected1 = { 2, 2 };
            int expectedLength1 = 2;

            int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val2 = 2;
            int[] expected2 = { 0, 1, 3, 0, 4 };
            int expectedLength2 = 5;

            //Act
            int resultLength1 = solution.RemoveElements(nums1, val1);
            int resultLength2 = solution.RemoveElements(nums2, val2);

            //Assert
            Assert.That(expectedLength1, Is.EqualTo(resultLength1));
            for(int i = 0; i < expectedLength1; i++)
            {
                Assert.That(expected1[i], Is.EqualTo(nums1[i]));
            }

            Assert.That(expectedLength2, Is.EqualTo(resultLength2));
            for(int i = 0; i < expectedLength2; i++)
            {
                Assert.That(expected2[i], Is.EqualTo(nums2[i]));
            }
        }
    }
}
