# PrimeTables

* How to Run

Run the Site project and enter the number of prime numbers into the textbox, on the page that appears, and press the submit button.

* Good points

1. There is good separation of concerns between the site and the Primes class and the NumberListMultiplier class.
2. Good test coverage.

* What needs to be improved

1. EstimateSieveSizeFromNumberOfPrimes shouldn't really be public.
2. Need to have a better data structure for Multiples in PrimeMultiplesViewModel so that all rows are not in one list.
3. Need to deal with overflows in EstimateSieveSizeFromNumberOfPrimes.
