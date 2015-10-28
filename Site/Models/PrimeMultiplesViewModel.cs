using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class PrimeMultiplesViewModel
    {
        public IEnumerable<int> Primes { get; set; } 
        public IEnumerable<int> Multiples { get; set; }  
        public int NumberOfPrimes { get; set; }
        [Display(Name= "The following error occurred:")]
        public string ErrorMessage { get; set; }
    }
}