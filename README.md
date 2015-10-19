# PrimeTables

* How to Run

Update line 21 of HomeController to pass in a value of numberOfPrimes to GetFirstNPrimes and run the Site project to see the table that is generated.

* Good points

There is good separation of concerns between the site and the Primes class and the NumberListMultiplier class.
Good test coverage.

* What needs to be improved

EstimateSieveSizeFromNumberOfPrimes shouldn't really be public.
Need to create a textbox and button to accept a number from the user, with which to generate the table.
Need to have a better data structure for Multiples in PrimeMultiplesViewModel so that all rows are not in one list.
Need to deal with overflows in EstimateSieveSizeFromNumberOfPrimes.
