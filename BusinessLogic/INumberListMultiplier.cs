using System.Collections.Generic;

namespace BusinessLogic
{
    public interface INumberListMultiplier
    {
        IEnumerable<int> Multiply(IEnumerable<int> primes);
    }
}
