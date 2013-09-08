(function () {
    var pickedBenchObservable = WinJS.Binding.as(Models.getBenchDTO());
    var benchUsersLists = new WinJS.Binding.List([]);


    function changeBenchPick(benchId) {
        var pickedBench = Data.getBenchById(benchId);

        pickedBenchObservable.Id = pickedBench.Id;
        pickedBenchObservable.Name = pickedBench.Name;
        pickedBenchObservable.UsersCount = pickedBench.UsersCount;
        pickedBenchObservable.Latitude = pickedBench.Latitude;
        pickedBenchObservable.Longitude = pickedBench.Longitude;
        pickedBenchObservable.StartTime = pickedBench.Longitude;
        pickedBenchObservable.EndTime = pickedBench.Longitude;
        pickedBenchObservable.Users = pickedBench.Users;

        // Rebind users in current bench
        benchUsersLists.length = 0;
        for (var i = 0; i < pickedBench.Users.length; i++) {
            benchUsersLists.push(pickedBenchObservable.Users[i]);
            var userFromBench = Data.getUserById(pickedBenchObservable.Users[i].id);

            if (userFromBench === null) {
                var newUser =  new Models.getUserDTO();
                newUser.Id = pickedBenchObservable.Users[i].id;
                newUser.FirstName = pickedBenchObservable.Users[i].firstname;
                newUser.Nickname = pickedBenchObservable.Users[i].nickname;
                Data.addUser(newUser);
            }
        }
    }

    WinJS.Namespace.define("ViewModels", {
        changeBenchPick: changeBenchPick,
        pickedBench: pickedBenchObservable,
        benchUsersLists: benchUsersLists

    });

})();