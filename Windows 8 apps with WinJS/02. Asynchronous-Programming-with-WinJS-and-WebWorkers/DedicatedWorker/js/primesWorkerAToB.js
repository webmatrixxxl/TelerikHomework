/// <reference group="Dedicated Worker" />

var isPrime = function (number) {
    for (var i = 2; i < number; i++) {
        if (number % i == 0) {
            return false;
        }
    }
    return true;
}

var calculatePrimes = function (fromNumber, toNumber) {
    var primesList = [];

    for (var num = fromNumber; num <= toNumber; num++) {
        if (isPrime(num)) {
            primesList.push(num);
        }
    }

    return primesList;
}

onmessage = function (event) {
    var firstNumber = event.data.firstNumber;
    var lastNumber = event.data.lastNumber;

    var primes = calculatePrimes(firstNumber, lastNumber);

    postMessage(primes);
}
