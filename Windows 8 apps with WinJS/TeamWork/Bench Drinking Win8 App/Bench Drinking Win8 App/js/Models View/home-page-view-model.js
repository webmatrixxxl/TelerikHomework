/// <reference path="../Data Layer/data-layer.js" />
(function () {
    var benches = Data.getAllBenches();
    var benchesList = new WinJS.Binding.List(benches);

    //var benchUsers = Data.getBenchUsers(51);
    //var benchUsersLists = new WinJS.Binding.List(benchUsers);


    var users = Data.getAllUsers();
    var usersList = new WinJS.Binding.List(users);


    var addBench = function (bench) {
        Data.addBench(bench).then(function () {
            benchesList.push(bench);
        });
    }

    WinJS.Namespace.define("ViewModels", {
        allBenchesList: benchesList,
        addBench: addBench,
        //benchUsers:benchUsersLists,
        allUsersList: usersList,
    });
})();