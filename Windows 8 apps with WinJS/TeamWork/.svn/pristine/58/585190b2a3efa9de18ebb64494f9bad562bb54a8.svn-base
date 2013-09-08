(function () {
    function navigateToBenchEventDetailItem(event) {
        event.detail.itemPromise.then(function (item) {
            WinJS.Navigation.navigate(
                "/pages/bench-details/bench-details.html", {
                    itemIndex: event.detail.itemIndex,
                    // Get Bench by Id
                    Id: item.data.Id
                });
        });
    }

    function navigateToUserEventDetailItem(event) {
        event.detail.itemPromise.then(function (item) {
            WinJS.Navigation.navigate(
                "/pages/user-details/user-details.html", {
                    itemIndex: event.detail.itemIndex,
                    // Get User by Id
                    Id: item.data.id
                });
        });
    }

    function createBench(event) {
        var name = document.getElementById("name").value;
        var newBench = Models.getBenchDTO();
        // TODO: Add Current User to newly created bench as Creator
        newBench.Name = name;
        ViewModels.addBench(newBench);
    }

    WinJS.Utilities.markSupportedForProcessing(createBench);
    WinJS.Utilities.markSupportedForProcessing(navigateToBenchEventDetailItem);
    WinJS.Utilities.markSupportedForProcessing(navigateToUserEventDetailItem);


    WinJS.Namespace.define("Commands", {
        navigateToBenchEventDetailItem: navigateToBenchEventDetailItem,
        createBench: createBench,
        navigateToUserEventDetailItem: navigateToUserEventDetailItem,

    });
})();