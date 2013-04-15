 function onClock(event, arguments) {
            var currentWindow = window;
            var browserName = myWindow.navigator.appCodeName;
            var isMozilla = browser == "Mozilla";
            if (isMozilla) {
                alert("Yes");
            }
            else {
                alert("No");
            }
        }