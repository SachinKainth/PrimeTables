using System.Collections.Generic;

namespace Site.Models
{
    public class PrimeMultiplesViewModel
    {
        public IEnumerable<int> Primes { get; set; } 
        public IEnumerable<int> Multiples { get; set; } 
    }
}