(function () {
    var pickedUserObservable = WinJS.Binding.as(Models.getUserDTO());

    function changeUserPick(userId) {
        var pickedUser = Data.getUserById(userId);
        // TODO: Compleat data binding
        pickedUserObservable.Id = pickedUser.Id;
        pickedUserObservable.Nickname = pickedUser.Nickname;
        pickedUserObservable.Firstname = pickedUser.Firstname;
        pickedUserObservable.Lastname = pickedUser.Lastname;
        pickedUserObservable.Avatar = pickedUser.Avatar;
        pickedUserObservable.BenchId = pickedUser.BenchId;
    }

    WinJS.Namespace.define("ViewModels", {
        changeUserPick: changeUserPick,
        pickedUser: pickedUserObservable
    });



})();