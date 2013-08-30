var calculations = (function () {
    "use strict";

    var isPrime = function(number) {
        for (var i = 2; i < number; i++) {
            if (number % i == 0) {
                return false;
            }
        }
        return true;
    };

    function primeNumberTo(toNumber) {
        var primesList = new Array();

        for (var ind = 1; ind < toNumber; ind++) {
            if (isPrime(ind)) {
                primesList.push(ind);
            }
        }

        return primesList;
    }

    function primeFromRange(startNumber, endNumber) {
        var primesList = new Array();

        for (var ind = startNumber; ind < endNumber; ind++) {
            if (isPrime(ind)) {
                primesList.push(ind);
            }
        }

        return primesList;
    }

    function primeFirstNumbers(toNumber, stopNumber) {
        var primesList = new Array();

        for (var ind = 1; ind < toNumber; ind++) {
            if (isPrime(ind)) {
                if (primesList.length < stopNumber) {
                    primesList.push(ind);
                } else {
                    break;
                }
            }
        }

        return primesList;
    }

    return {
        primeNumberTo: function (toNumber) {
            return primeNumberTo(toNumber);
        },
        primeFromRange: function (startNumber, endNumber) {
            return primeFromRange(startNumber, endNumber);
        },
        primeFirstNumbers: function (toNumber, stopNumber) {
            return primeFirstNumbers(toNumber, stopNumber);
        }
    };
})();