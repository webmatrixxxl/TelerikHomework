(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/home/home.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {

            var dataList = [];
            dataList.push(Data.getComputer("Dell Studio 1535", 2000, "http://www.laptoptestovi.com/images/stories/testovi/Dell/Studio_1535/Dell_studio_1535_laptop.jpg", "Core i5", 2.0));
            dataList.push(Data.getComputer("HP 650", 1500, "http://www.mega.pk/items_images/6900hp_650_c1n10ea.jpg", "Intel 1000M", 1.8));
            dataList.push(Data.getComputer("Dell Studio 1535", 2000, "http://www.laptoptestovi.com/images/stories/testovi/Dell/Studio_1535/Dell_studio_1535_laptop.jpg", "Core i5", 2.0));
            
            var repeater = document.getElementById("grdRepeater");

            for (var i = 0; i < dataList.length; i++) {
                var computerTemplate = document.getElementById("computer-template-container").winControl;
                computerTemplate.render(dataList[i], repeater);
            }

            var btnSave = document.getElementById("btnSave");
            btnSave.onclick = function (e) {
                var txtName = document.getElementById("txtName").value;
                var txtPrice = document.getElementById("txtPrice").value;
                var txtImage = document.getElementById("txtImage").value;
                var txtModelName = document.getElementById("txtModelName").value;
                var txtFrequencyGHz = document.getElementById("txtFrequencyGHz").value;
                var computerTemplate = document.getElementById("computer-template-container").winControl;
                computerTemplate.render(Data.getComputer(txtName, txtPrice, txtImage, txtModelName, txtFrequencyGHz), repeater);
            };
        }
    });
})();
