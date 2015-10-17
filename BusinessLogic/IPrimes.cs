using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IPrimes
    {
        int EstimateSieveSizeFromNumberOfPrimes(int numberOfPrimes);
        List<int> GetFirstNPrimes(int numberOfPrimes);
    }
}
