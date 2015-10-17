using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class NumberListMultiplier : INumberListMultiplier
    {
        public IEnumerable<int> Multiply(IEnumerable<int> primes)
        {
            var ps = primes.ToList();
            return (from prime1 in ps from prime2 in ps select prime1*prime2).ToList();
        }
    }
}