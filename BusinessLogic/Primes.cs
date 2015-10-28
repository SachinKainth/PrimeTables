using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class Primes : IPrimes
    {
        public int EstimateSieveSizeFromNumberOfPrimes(int numberOfPrimes)
        {
            if (numberOfPrimes <= 0)
                throw new InvalidNumberOfPrimesException("The number of primes cannot be 0 or less.");

            if (numberOfPrimes < 6) return 11;
           
            var sieveSize = numberOfPrimes*Math.Log(numberOfPrimes) + numberOfPrimes*Math.Log(Math.Log(numberOfPrimes));

            return (int)sieveSize;
        }

        public IEnumerable<int> GetFirstNPrimes(int numberOfPrimes)
        {
            if (numberOfPrimes <= 0)
                throw new InvalidNumberOfPrimesException("The number of primes cannot be 0 or less.");

            var sieveSize = EstimateSieveSizeFromNumberOfPrimes(numberOfPrimes);

            var primesInSieveSize = InitialisePrimes(sieveSize);

            SieveOutNonPrimes(sieveSize, primesInSieveSize);

            var primes = ExtractNPrimes(numberOfPrimes, primesInSieveSize);

            return primes;
        }

        private IEnumerable<int> ExtractNPrimes(int numberOfPrimes, bool[] primesInSieveSize)
        {
            return primesInSieveSize
                .Select((p, i) => new { number = i, isPrime = p })
                .Where(p => p.isPrime)
                .Take(numberOfPrimes)
                .Select(p => p.number)
                .ToList();
        }

        private void SieveOutNonPrimes(int sieveSize, bool[] primesInSieveSize)
        {
            for (var i = 0; i*i < sieveSize; i++)
                if (primesInSieveSize[i])
                    for (var j = i*i; j < sieveSize; j += i)
                        primesInSieveSize[j] = false;
        }

        private bool[] InitialisePrimes(int sieveSize)
        {
            var primesInSieveSize = new bool[sieveSize + 1];

            primesInSieveSize[0] = false;
            primesInSieveSize[1] = false;

            for (var i = 2; i <= sieveSize; i++) primesInSieveSize[i] = true;

            return primesInSieveSize;
        }
    }
}