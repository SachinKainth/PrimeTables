using System.Collections.Generic;
using BusinessLogic;
using FluentAssertions;
using NUnit.Framework;

namespace BusinessLogicTests
{
    [TestFixture]
    class PrimesTests
    {
        private IPrimes _primes;

        [SetUp]
        public void Setup()
        {
            _primes = new Primes();
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void EstimateSieveSizeFromNumberOfPrimes_When0OrLess_ThrowsException(int numberOfPrimes)
        {
            _primes
                .Invoking(p => p.EstimateSieveSizeFromNumberOfPrimes(numberOfPrimes))
                .ShouldThrow<InvalidNumberOfPrimesException>()
                .WithMessage("The number of primes cannot be 0 or less.");
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void EstimateSieveSizeFromNumberOfPrimes_WhenLessThan6_Returns11(int numberOfPrimes)
        {
            _primes.EstimateSieveSizeFromNumberOfPrimes(numberOfPrimes).Should().Be(11);
        }
        
        [Test]
        public void EstimateSieveSizeFromNumberOfPrimes_When6_ReturnsAtLeast13()
        {
            _primes.EstimateSieveSizeFromNumberOfPrimes(6).Should().BeGreaterOrEqualTo(13);
        }

        [Test]
        public void EstimateSieveSizeFromNumberOfPrimes_When7_ReturnsAtLeast17()
        {
            _primes.EstimateSieveSizeFromNumberOfPrimes(7).Should().BeGreaterOrEqualTo(17);
        }

        [Test]
        public void EstimateSieveSizeFromNumberOfPrimes_When8_ReturnsAtLeast19()
        {
            _primes.EstimateSieveSizeFromNumberOfPrimes(8).Should().BeGreaterOrEqualTo(19);
        }

        [Test]
        public void EstimateSieveSizeFromNumberOfPrimes_When9_ReturnsAtLeast23()
        {
            _primes.EstimateSieveSizeFromNumberOfPrimes(9).Should().BeGreaterOrEqualTo(23);
        }

        [Test]
        public void EstimateSieveSizeFromNumberOfPrimes_When10_ReturnsAtLeast29()
        {
            _primes.EstimateSieveSizeFromNumberOfPrimes(10).Should().BeGreaterOrEqualTo(29);
        }

        [Test]
        public void EstimateSieveSizeFromNumberOfPrimes_When168_ReturnsAtLeast997()
        {
            _primes.EstimateSieveSizeFromNumberOfPrimes(168).Should().BeGreaterOrEqualTo(997);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetFirstNPrimes_When0OrLess_ThrowsException(int numberOfPrimes)
        {
            _primes
                .Invoking(p => p.GetFirstNPrimes(numberOfPrimes))
                .ShouldThrow<InvalidNumberOfPrimesException>()
                .WithMessage("The number of primes cannot be 0 or less.");
        }

        [Test]
        public void GetFirstNPrimes_When1_ReturnsList()
        {
            _primes.GetFirstNPrimes(1).Should().BeEquivalentTo(new List<int> {2});
        }

        [Test]
        public void GetFirstNPrimes_When2_ReturnsList()
        {
            _primes.GetFirstNPrimes(2).Should().BeEquivalentTo(new List<int> { 2, 3 });
        }

        [Test]
        public void GetFirstNPrimes_When3_ReturnsList()
        {
            _primes.GetFirstNPrimes(3).Should().BeEquivalentTo(new List<int> { 2, 3, 5 });
        }

        [Test]
        public void GetFirstNPrimes_When4_ReturnsList()
        {
            _primes.GetFirstNPrimes(4).Should().BeEquivalentTo(new List<int> { 2, 3, 5, 7 });
        }

        [Test]
        public void GetFirstNPrimes_When5_ReturnsList()
        {
            _primes.GetFirstNPrimes(5).Should().BeEquivalentTo(new List<int> { 2, 3, 5, 7, 11 });
        }

        [Test]
        public void GetFirstNPrimes_When6_ReturnsList()
        {
            _primes.GetFirstNPrimes(6).Should().BeEquivalentTo(new List<int> { 2, 3, 5, 7, 11, 13 });
        }

        [Test]
        public void GetFirstNPrimes_When7_ReturnsList()
        {
            _primes.GetFirstNPrimes(7).Should().BeEquivalentTo(new List<int> { 2, 3, 5, 7, 11, 13, 17 });
        }

        [Test]
        public void GetFirstNPrimes_When8_ReturnsList()
        {
            _primes.GetFirstNPrimes(8).Should().BeEquivalentTo(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 });
        }

        [Test]
        public void GetFirstNPrimes_When9_ReturnsList()
        {
            _primes.GetFirstNPrimes(9).Should().BeEquivalentTo(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23 });
        }

        [Test]
        public void GetFirstNPrimes_When10_ReturnsList()
        {
            _primes.GetFirstNPrimes(10).Should().BeEquivalentTo(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 });
        }

        [Test]
        public void GetFirstNPrimes_When168_ReturnsList()
        {
            _primes.GetFirstNPrimes(168).Should().BeEquivalentTo(
                new List<int>
                {
                    2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73,  79, 83, 89, 97,
                    101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199,
                    211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293,
                    307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397,
                    401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499,
                    503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599,
                    601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691,
                    701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797,
                    809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887,
                    907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997
                });
        }
    }
}