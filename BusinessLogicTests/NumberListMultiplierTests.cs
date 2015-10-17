using System.Collections.Generic;
using BusinessLogic;
using FluentAssertions;
using NUnit.Framework;

namespace BusinessLogicTests
{
    [TestFixture]
    internal class NumberListMultiplierTests
    {
        private INumberListMultiplier _numberListMultiplier;

        [SetUp]
        public void Setup()
        {
            _numberListMultiplier = new NumberListMultiplier();
        }

        [Test]
        public void Multiply_When1Number_ReturnsList()
        {
            var list = new List<int> {2};
            var expectedList = new List<int> {4};

            _numberListMultiplier.Multiply(list).Should().BeEquivalentTo(expectedList);
        }

        [Test]
        public void Multiply_When2Numbers_ReturnsList()
        {
            var list = new List<int> { 2, 3 };
            var expectedList = new List<int> { 4, 6, 6, 9 };

            _numberListMultiplier.Multiply(list).Should().BeEquivalentTo(expectedList);
        }

        [Test]
        public void Multiply_When3Numbers_ReturnsList()
        {
            var list = new List<int> { 2, 3, 5 };
            var expectedList = new List<int> { 4, 6, 10, 6, 9, 15, 10, 15, 25 };

            _numberListMultiplier.Multiply(list).Should().BeEquivalentTo(expectedList);
        }
    }
}
