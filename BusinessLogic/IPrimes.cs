using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IPrimes
    {
        int EstimateSieveSizeFromNumberOfPrimes(int numberOfPrimes);
        IEnumerable<int> GetFirstNPrimes(int numberOfPrimes);
    }
}