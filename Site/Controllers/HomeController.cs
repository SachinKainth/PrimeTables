using System;
using System.Linq;
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
            return View();
        }

        [HttpPost]
        public ActionResult GenerateTable(PrimeMultiplesViewModel model)
        {
            try
            {
                var primes = _primes.GetFirstNPrimes(model.NumberOfPrimes).ToList();
                var multiples = _numberListMultiplier.Multiply(primes);

                model.Primes = primes;
                model.Multiples = multiples;
            }
            catch (Exception e)
            {
                model.ErrorMessage = e.Message;
            }
            
            return View("PrimesMultiplesTable", model);
        }
    }
}