// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    var primesWorker = {};
    var primeWorker1ToN = {};
    var primesWorker1ToNOfN = {};

    app.onactivated = function (args) {
        //worker created on app activation, NOT on demand (worker creation is slow, better pre-initialize than lazy-initialize)
       var _primesWorker = 0;
        var _primeWorker1ToN = 0;
        var _primesWorker1ToNOfN = 0;

        primesWorker = new Worker("/js/primesWorkerAToB.js");
        primeWorker1ToN = new Worker("/js/primesWorker1ToN.js");
        primesWorker1ToNOfN = new Worker("/js/primesWorker1ToNOfN.js");

        args.setPromise(WinJS.UI.processAll());

        primesWorker.onmessage = function (event) {
            var primesPar = document.createElement("p");
            primesPar.innerText = event.data.join(", ");
            document.body.appendChild(primesPar)
        }

        primesWorker1ToNOfN.onmessage = function (event) {
            var primesPar = document.createElement("p");
            primesPar.innerText = event.data.join(", ");
            document.body.appendChild(primesPar);
        }

        var calculatePrimesButton = document.getElementById("calculate-primes");
        var primesFirstInput = document.getElementById("primes-first");
        var primesLastInput = document.getElementById("primes-last");

        var calculatePrimesButton1toN = document.getElementById("calculate-primes-1toN");
        var primesLastInputN = document.getElementById("primes-last-N");

        var calculatePrimesButtonNbyN = document.getElementById("calculate-primes-NbyN");
        var primesLastInputNbyN = document.getElementById("primes-NbyN");



        calculatePrimesButton.addEventListener("click", function () {
            primesWorker.postMessage({ firstNumber: primesFirstInput.value, lastNumber: primesLastInput.value });
            _primesWorker++;
        });

        
        calculatePrimesButton1toN.addEventListener("click", function () {
            myfunction().then(function (result) {
                document.body.appendChild(result)
            }, function (error) {
                document.body.appendChild(document.createElement("span").innerText = "error");
            });
        });

        function myfunction() {
            return new WinJS.Promise(function (complete, error) {
                primeWorker1ToN.postMessage({ firstNumber: 1, lastNumber: primesLastInputN.value });
                _primeWorker1ToN++;

                primeWorker1ToN.onmessage = function (event) {
                    

                    if (event.data && _primeWorker1ToN < 3) {
                        var primesPar = document.createElement("p");
                        primesPar.innerText = event.data.join(", ");
                        complete(primesPar);
                        _primeWorker1ToN--;
                    }
                    else if (_primeWorker1ToN>=3) {
                        error("Error");
                    }
                }
              
            });
        }

        calculatePrimesButtonNbyN.addEventListener("click", function () {
            primesWorker1ToNOfN.postMessage({ nNumber: primesLastInputNbyN.value });
            _primesWorker1ToNOfN++;
        });
    };

    app.start();
})();
