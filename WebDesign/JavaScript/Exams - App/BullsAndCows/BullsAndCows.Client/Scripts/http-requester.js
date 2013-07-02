/// <reference path="jquery-2.0.2.js" />
/// <reference path="class.js" />

var httpRequester = (function () {
    function getJSON(url, success, error) {
        $.ajax({
            url: url,
            type: "GET",
            timeout: 5000,
            contentType: "application/json",
            success: success,
            error: error

        })
    }

    function postJSON(url, data, success, error) {
        $.ajax({
            url: url,
            data: JSON.stringify(data),
            type: "POST",
            timeout: 5000,
            contentType: "application/json",
            success: success,
            error: error

        })
    }

    return {
        getJSON: getJSON,
        postJSON: postJSON
    }

})();

//var user = {
//    "username": "Dodo",
//    //"nikname": "Doncho Minkov",
//    "authCode": "6fa9133efe05348e430bd5a4585b595f0cb6cba3"
//}



//httpRequester.postJSON(
//    "http://localhost:40643/api/user/login",
//    user,
//    function () {
//        alert("Success")
//    },
//    function () {
//        alert("Error");
//    }
//    );
