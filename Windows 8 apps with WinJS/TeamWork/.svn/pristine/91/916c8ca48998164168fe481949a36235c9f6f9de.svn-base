(function () {
    var user = {
        Firstname: "",
        Lastname: "",
        Nickname: "",
        Avatar: "",
        AuthCode: ""
    }

    var getUser = function (firstname, lastname, nickname, avatar, authCode) {
        return new ObservableUser({
            Firstname: firstname,
            Lastname: lastname,
            Nickname: nickname,
            Avatar: avatar,
            AuthCode: authCode
        });
    }
    var ObservableUser = WinJS.Binding.define(user);
    var usersList = new WinJS.Binding.List(getUser(ObservableUser));
    WinJS.Namespace.define("Data", {
        users: usersList
    });
})()