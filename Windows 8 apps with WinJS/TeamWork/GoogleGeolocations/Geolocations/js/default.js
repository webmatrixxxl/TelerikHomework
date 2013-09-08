(function () {
    "use strict";
    var coordField;
    var addrField;
    var lat, lon, map;
    var bingMapsKey = "Ao8BXMSj1r9dqbKiVs-FwH4MiGpLa29SeGrHm7_4j54oYugi1G-O_cx2tQuyYZb7";
    WinJS.UI.Pages.define("/default.html", {
        ready: function (element, options) {
        }
    });
    function getLocation() {
        coordField = document.getElementById('coordinates');
        addrField = document.getElementById('address');
        var locator = new Windows.Devices.Geolocation.Geolocator();
        locator.getGeopositionAsync().done(populateMap, err);
        //populateMap();
    }
    function DisplayLoc(e) {
        if (e.targetType == 'pushpin') {

            var pinLoc = e.target.getLocation();
            lat = pinLoc.latitude;
            lon = pinLoc.longitude;
            coordField.innerText = 'Current latitude: ' + lat + ' and longitude: ' + lon;
            //var md = new Windows.UI.Popups.MessageDialog("The location of the pushpin is now " + pinLoc.latitude + ", " + pinLoc.longitude);
            //md.showAsync();
        }
    }
    function populateMap(position) {

        lat = position.coordinate.latitude;//42.68422816297158;//
        lon = position.coordinate.longitude;//23.33519497656249;//
        var city = position.civicAddress.city;//"Sofia";//
        var state = position.civicAddress.state;//"BG";//
        coordField.innerText = 'Current latitude: ' + lat + ' and longitude: ' + lon;
        if (city) {
            addrField.innerText = 'This is in:  ' + city + ', ' + state;
        }
        try {
            var mapOptions =
            {
                credentials: bingMapsKey,
                center: new Microsoft.Maps.Location(lat, lon),
                mapTypeId: Microsoft.Maps.MapTypeId.road,
                zoom: 14,
                height: 500,
                width: 500
            };
            map = new Microsoft.Maps.Map(document.getElementById("mapdiv"), mapOptions);
            // Add a pin to the center of the map
            var pin = new Microsoft.Maps.Pushpin(mapOptions.center, { draggable: true });

            // Add a handler to the pushpin drag
            Microsoft.Maps.Events.addHandler(pin, 'mouseup', DisplayLoc);

            map.entities.push(pin);
        }
        catch (e) {
            var md = new Windows.UI.Popups.MessageDialog(e.message);
            md.showAsync();
        }
    }
    function err(e) {
        console.log(e.message);
    }
    function initialize() {
        Microsoft.Maps.loadModule('Microsoft.Maps.Map', { callback: getLocation });
    }
    document.addEventListener("DOMContentLoaded", initialize, false);

})();