# PrimeTables

* How to Run

Update line 21 of HomeController to pass in a value of numberOfPrimes to GetFirstNPrimes and run the Site project to see the table that is generated.

* Good points

1. There is good separation of concerns between the site and the Primes class and the NumberListMultiplier class.
2. Good test coverage.

* What needs to be improved

1. EstimateSieveSizeFromNumberOfPrimes shouldn't really be public.
2. Need to create a textbox and button to accept a number from the user, with which to generate the table.
3. Need to have a better data structure for Multiples in PrimeMultiplesViewModel so that all rows are not in one list.
4. Need to deal with overflows in EstimateSieveSizeFromNumberOfPrimes.
