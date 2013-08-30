// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {

        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }

            args.setPromise(WinJS.UI.processAll());

            var startTime = document.getElementById("start-time")
            startTime.style.display = "none";
            var endTime = document.getElementById("end-time");
            endTime.style.display = "none";
           

            var startDate = document.getElementById("start-date");
            var endDate = document.getElementById("end-date");
            var openElement = document.getElementById("open-button-id");

            openElement.addEventListener("click", openElementClicked);

            var toggle = document.getElementById("toggle");
            toggle.addEventListener("change", onToggleClick);

            var btnCalculateDays = document.getElementById("CalcolateDays");
            var btnCalculateHours = document.getElementById("CalculateHours");
            var btnCalculateDaysAndHours = document.getElementById("CalculateDaysAndHours");
            var results = document.getElementById("result");

            btnCalculateDays.addEventListener("click", function (e) {
                var result = daysBetween(startDate.winControl.current, endDate.winControl.current);
                results.innerHTML = "Days: " + result;
            });

            btnCalculateHours.addEventListener("click", function (e) {
                var result = hoursBetween(startTime.winControl.current, endTime.winControl.current);
                results.innerHTML = "Hours: " + result;
            });

            btnCalculateDaysAndHours.addEventListener("click", function (e) {
                var resultDays = daysBetween(startDate.winControl.current, endDate.winControl.current);
                var resultHours = hoursBetween(startTime.winControl.current, endTime.winControl.current);
                results.innerHTML = "Days: " + resultDays + " Hours: " + resultHours;
            });


        }
    };

    var onToggleClick = function () {
        var startTime = document.getElementById("start-time");
        var endTime = document.getElementById("end-time");
        var toggle = document.getElementById("toggle").winControl;

        var btnCalculateHours = document.getElementById("CalculateHours").winControl;
        var btnCalculateDaysAndHours = document.getElementById("CalculateDaysAndHours").winControl;

        if (toggle.checked) {
            startTime.style.display = "inline";
            endTime.style.display = "inline";
            btnCalculateHours.disabled = false;
            btnCalculateDaysAndHours.disabled = false;
        } else {
            btnCalculateHours.disabled = true;
            btnCalculateDaysAndHours.disabled = true;
            startTime.style.display = "none";
            endTime.style.display = "none";
        }
    }

    var openElementClicked = function () {
        var menu = document.getElementById("menu-id").winControl;
        menu.show();
    }

    var daysBetween = function (date1, date2) {
        //Get 1 day in milliseconds
        var oneDay = 1000 * 60 * 60 * 24;

        // Convert both dates to milliseconds
        var date1Ms = date1.getTime();
        var date2Ms = date2.getTime();

        // Calculate the difference in milliseconds
        var differenceMs = date2Ms - date1Ms;

        // Convert back to days and return
        return Math.round(differenceMs / oneDay);
    };

    var hoursBetween = function (date1, date2) {
        //Get 1 hour in milliseconds
        var oneHour = 1000 * 60 * 60;

        // Convert both dates to milliseconds
        var date1Ms = date1.getTime();
        var date2Ms = date2.getTime();

        // Calculate the difference in milliseconds
        var differenceMs = date2Ms - date1Ms;

        // Convert back to days and return
        return differenceMs / oneHour;
    };

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    app.start();
})();