/// <reference path="animal.js" />
/// <reference path="dom-logger.js" />
(function () {
    WinJS.Application.onactivated = function () {

        var heartTomato = new Plants.Vegetables.Tomato("Розов домат", 10);
        //var store_oughtCucumber = new Cucumber("Купешка краставица", 25);

        console = new DomLogger(document.getElementById("output"));

        heartTomato.info();
        //console.log(heartTomato.name + " " + heartTomato.color + " " + heartTomato.radios + " " + heartTomato.directlyEaten);
        //console.log(store_oughtCucumber.name + " " + store_oughtCucumber.color + " " + store_oughtCucumber.length + " " + store_oughtCucumber.directlyEaten);



    };



    WinJS.Application.start();
})();
