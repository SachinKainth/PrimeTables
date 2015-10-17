using System.Web.Mvc;
using BusinessLogic;
using Site.Models;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly INumberListMultiplier _numberListMultiplier;
        private readonly IPrimes _primes;

        public HomeController(INumberListMultiplier numberListMultiplier, IPrimes primes)
        {
            _numberListMultiplier = numberListMultiplier;
            _primes = primes;
        }

        // GET: Default
        public ActionResult Index()
        {
            var primes = _primes.GetFirstNPrimes(5);
            var multiples = _numberListMultiplier.Multiply(primes);

            return View(new PrimeMultiplesViewModel { Primes = primes, Multiples = multiples });
        }
    }
}