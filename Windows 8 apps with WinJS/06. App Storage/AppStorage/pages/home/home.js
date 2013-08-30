(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/home/home.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            var appCache = new AppCache("workers.txt");

            var calculate = new PrimeNumbersCalculator();

            var btnCalculatePrimeNumberTo = document.getElementById("btnCalculatePrimeNumberTo");
            btnCalculatePrimeNumberTo.addEventListener("click", function (e) {
                var txtToNumber = document.getElementById("txtToNumber");
                var pnlResult = document.getElementById("result-calculatePrimeNumberTo");
                var workerData = new WorkerData(txtToNumber.value);
                var result = appCache.get("calculatePrimeNumberTo", workerData);
                if (result === undefined) {
                    calculate.calculatePrimeNumberTo(txtToNumber.value).then(function (response) {
                        workerData.result = response;
                        appCache.pushSafe("calculatePrimeNumberTo", workerData);
                        pnlResult.innerHTML = response;
                    }, function (error) {
                        pnlResult.innerHTML = error;
                    });
                } else {
                    pnlResult.innerHTML = result.result;
                }
            });

            var btnCalculateFirstNumbers = document.getElementById("btnCalculateFirstNumbers");
            btnCalculateFirstNumbers.addEventListener("click", function (e) {
                var txtToNumber = document.getElementById("txtNumber");
                var txtStopNumber = document.getElementById("txtStopNumber");
                var pnlResult = document.getElementById("result-calculateFirstNumbers");
                var workerData = new WorkerData(txtToNumber.value, txtStopNumber.value);
                var result = appCache.get("calculateFirstNumbers", workerData);
                if (result === undefined) {
                    calculate.calculateFirstNumbers(txtToNumber.value, txtStopNumber.value).then(function (response) {
                        workerData.result = response;
                        appCache.pushSafe("calculateFirstNumbers", workerData);
                        pnlResult.innerHTML = response;
                    }, function (error) {
                        pnlResult.innerHTML = error;
                    });
                } else {
                    pnlResult.innerHTML = result.result;
                }
            });

            var btnCalculateFromRange = document.getElementById("btnCalculateFromRange");
            btnCalculateFromRange.addEventListener("click", function (e) {
                var txtStartNumber = document.getElementById("txtStartNumber");
                var txtEndNumber = document.getElementById("txtEndNumber");
                var pnlResult = document.getElementById("result-calculateFromRange");
                var workerData = new WorkerData(txtStartNumber.value, txtEndNumber.value);
                var result = appCache.get("calculateFromRange", workerData);
                if (result === undefined) {
                    calculate.calculateFromRange(txtStartNumber.value, txtEndNumber.value).then(function (response) {
                        workerData.result = response;
                        appCache.pushSafe("calculateFromRange", workerData);
                        pnlResult.innerHTML = response;
                    }, function (error) {
                        pnlResult.innerHTML = error;
                    });
                } else {
                    pnlResult.innerHTML = result.result;
                }
            });
        }
    });
})();
