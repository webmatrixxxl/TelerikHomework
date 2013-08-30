// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511
(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/settings/preferences.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            var defaultWorkerNumber = Windows.Storage.ApplicationData.current.localSettings.values["workerNumber"];

            if (defaultWorkerNumber === undefined) {
                defaultWorkerNumber = 3;
            }

            var txtWorkerNumber = document.getElementById("txtWorkerNumber");
            txtWorkerNumber.value = defaultWorkerNumber;

            var btnSave = document.getElementById("btnSave");
            btnSave.onclick = function(e) {
                Windows.Storage.ApplicationData.current.localSettings.values["workerNumber"] = txtWorkerNumber.value;
            };
        },

        unload: function () {
            // TODO: Respond to navigations away from this page.
        },

        updateLayout: function (element, viewState, lastViewState) {
            /// <param name="element" domElement="true" />

            // TODO: Respond to changes in viewState.
        }
    });
})();
