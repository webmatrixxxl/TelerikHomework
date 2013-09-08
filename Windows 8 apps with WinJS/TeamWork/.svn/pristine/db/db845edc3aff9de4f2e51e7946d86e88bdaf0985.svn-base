/// <reference path="sha256.js" />
/// <reference path="../Data Layer/data-layer.js" />
// For Social networking sites

(function () {
    "use strict";
    //FOR LIST OF FRIENDS
    var friendslist = new WinJS.Binding.List();

    // TODO: Replace the data with your real data.
    // You can add data from asynchronous sources whenever it becomes available.

    // Get a reference for an item, using the group key and item title as a
    // unique reference to the item that can be easily serialized.
    function getItemReference(item) {
        return [item.group.key, item.title];
    }

    // This function returns a WinJS.Binding.List containing only the items
    // that belong to the provided group.
    function getItemsFromGroup(group) {
        return friendslist.createFiltered(function (item) { return item.group.key === group.key; });
    }

    // Get the unique group corresponding to the provided group key.
    function resolveGroupReference(key) {
        for (var i = 0; i < groupedItems.groups.length; i++) {
            if (groupedItems.groups.getAt(i).key === key) {
                return groupedItems.groups.getAt(i);
            }
        }
    }

    // Get a unique item from the provided string array, which should contain a
    // group key and an item title.
    function resolveItemReference(reference) {
        for (var i = 0; i < groupedItems.length; i++) {
            var item = groupedItems.getAt(i);
            if (item.group.key === reference[0] && item.title === reference[1]) {
                return item;
            }
        }
    }
    // Sorts the groups.
    function compareGroups(leftKey, rightKey) {
        return leftKey.charCodeAt(0) - rightKey.charCodeAt(0);
    }

    // Returns the group key that an item belongs to.
    function getGroupKey(dataItem) {
        return dataItem.group.key.toUpperCase().charAt(0);
    }

    // Returns the title for a group.
    function getGroupData(dataItem) {
        return {
            title: dataItem.group.title.toUpperCase().charAt(0)
        };
    }

    // Create the groups for the ListView from the item data and the grouping functions
    var groupedItemsList = friendslist.createGrouped(getGroupKey, getGroupData, compareGroups);


    var letters = ["~!@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U",
    "V", "W", "X", "Y", "Z"];
    var alphabets = [];

    letters.forEach(function (l) {
        alphabets.push({ key: l + l, title: l });

    });
    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var nav = WinJS.Navigation;
    var that;
    WinJS.Namespace.define("Social", {
        Facebook: WinJS.Class.define(
            function () {
                that = this;
                this.FacebookURL = "https://www.facebook.com/dialog/oauth?client_id=" + this.AppID +
                    "&redirect_uri=" + this.RedirectURL +
                    "&display=popup&scope=" + this.Scope + "&response_type=token";
            }, {
                //Properties
                LoggedUser: null,
                LoggedIn: false,
                User: null,
                Friends: null,
                AccessToken: null,
                AppID: 356411541157280,//REPLACE THIS WITH YOUR FB APP ID
                RedirectURL: "https%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html",
                Scope: "user_status,read_stream",
                CallbackURL: "https://www.facebook.com/connect/login_success.html",
                FacebookURL: {
                    set: function (value) { this._facebookURL = value; },
                    get: function () { return this._facebookURL; }
                },
                Graph_Get_userURL: "https://graph.facebook.com/me/?access_token=",
                Graph_Get_userFRIENDS: "https://graph.facebook.com/me/friends?access_token=",
                Graph_Get_Status: "https://graph.facebook.com/me/statuses",
                authzInProgress: false,
                //Methods
                Login: function () {

                    this.authzInProgress = true;
                    //start authentication
                    Windows.Security.Authentication.Web.WebAuthenticationBroker.authenticateAsync(
                        Windows.Security.Authentication.Web.WebAuthenticationOptions.none,
                        new Windows.Foundation.Uri(that.FacebookURL),
                        new Windows.Foundation.Uri(that.CallbackURL)).
                   then(function (result) {

                       //that.AccessToken = result.responseData.split('#')[1].split('&')[0].split('=')[1];
                       that.AccessToken = "CAAFEJ4dN9aABABctJTo8O2lZCyNHd80VBjZCcQMGK7vzE53M032ggFAYQZADKZCyhtQoz5RulwdyawVkZB9g9V8azkhhrBbeq5Oi1KQYbCnd6DIQhUZCGKJU8BPayw9KinbxamblT9ZADB0u8yZCDnQJio5dhrVKiZA7lSDAvPGbtYYZAKim9UeKbnTIZAFZBTDJGD4ZD"
                       that.authzInProgress = false;

                       //get user info
                       document.getElementById("prUser").style.display = "block";
                       WinJS.xhr({ url: that.Graph_Get_userURL + that.AccessToken }).done(function (user) {
                           that.User = JSON.parse(user.response);
                           that.User.pic = "https://graph.facebook.com/" + that.User.id + "/picture?type=large";
                           var userDiv = document.getElementById("userbinding");
                           WinJS.Binding.processAll(userDiv, that.User);
                           that.LoggedIn = true;
                           document.getElementById("appbar").winControl.disabled = true;
                           userDiv.style.display = "block";
                           document.getElementById("prUser").style.display = "none";
                           document.getElementById("prFriends").style.display = "block";
                           var hash = CryptoJS.SHA256(that.User.id);
                           var authCode = hash.toString(CryptoJS.enc.Hex);
                           var loginData = {
                               Firstname: that.User.first_name,
                               Lastname: that.User.last_name,
                               Nickname: that.User.username,
                               Avatar: that.User.pic,
                               AuthCode: authCode
                           };
                           //log in DrinkBench
                           WinJS.xhr({
                               url: "http://drinkbench.apphb.com/api/users/login",
                               type: "POST",
                               data: JSON.stringify(loginData),
                               headers: { "Content-type": "application/json" }
                           }).done(function (logedUser) {
                               that.LoggedUser = JSON.parse(logedUser.response);
                               WinJS.xhr({
                                   url: "http://drinkbench.apphb.com/api/benches/GetAll?sessionKey="
                                       + that.LoggedUser.sessionKey,
                                   type: "GET",
                                   headers: { "Content-type": "application/json" }
                               })
                               .done(function (benches) {
                                   var bencharray = JSON.parse(benches.response);

                                   for (var i = 0; i < bencharray.length; i++) {
                                       var newBench = new Models.getBenchDTO();
                                       newBench.Id = bencharray[i].id;
                                       newBench.Name = bencharray[i].name;
                                       newBench.Latitude = bencharray[i].latitude;
                                       newBench.Longitude = bencharray[i].longitude;
                                       newBench.StartTime = bencharray[i].startTime;
                                       newBench.EndTime = bencharray[i].endTime;
                                       newBench.Users = bencharray[i].users;
                                       ViewModels.addBench(newBench);
                                   }
                               });
                           });
                       });

                       //get friends

                       WinJS.xhr({ url: that.Graph_Get_userFRIENDS + that.AccessToken }).done(function (user) {
                           var friendsDiv = document.getElementById("friends");
                           that.Friends = JSON.parse(user.response);
                           that.Friends.data.forEach(function (f) {
                               f.pic = "https://graph.facebook.com/" + f.id + "/picture"

                               alphabets.forEach(function (a) {
                                   if (f.name[0].toString().toLowerCase() == a.title.toString().toLowerCase())
                                       f.group = a;
                               });
                               if (f.group == null)
                                   f.group = alphabets[0];

                               friendslist.push(f);
                           });
                           document.getElementById("prFriends").style.display = "none";
                           var zoomedInListView = document.querySelector("#zoomedInListView").winControl;
                           zoomedInListView.itemDataSource = groupedItemsList.dataSource;
                           zoomedInListView.groupDataSource = groupedItemsList.groups.dataSource;

                           var zoomedOutListView = document.querySelector("#zoomedOutListView").winControl;
                           zoomedOutListView.itemDataSource = groupedItemsList.groups.dataSource;

                       });

                   }, function (err) {

                       authzInProgress = false;
                   });
                }
            })
    });
})();
