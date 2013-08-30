/// <reference group="Dedicated Worker" />

var isPrime = function (number) {
    for (var i = 2; i < number; i++) {
        if (number % i == 0) {
            return false;
        }
    }
    return true;
}

var calculatePrimes = function (nNumber) {
    var primesList = [];

    for (var num = 0; num < nNumber; num++) {
        if (isPrime(num)) {
            primesList.push(num);
        }
    }

    return primesList;
}

onmessage = function (event) {
    var nNumber = event.data.nNumber;
  

    var primes = calculatePrimes(nNumber);

    postMessage(primes);
}
