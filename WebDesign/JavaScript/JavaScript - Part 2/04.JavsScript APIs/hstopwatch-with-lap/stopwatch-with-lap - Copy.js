var t = [0, 0, 0, 0, 0, 0, 0, 1];
var playerTime;

function startTimer() {
    t[t[2]] = (new Date()).valueOf();
    t[2] = 1 - t[2];

    if (0 == t[2]) {
        clearInterval(t[4]);
        t[3] += t[1] - t[0];
        var ttt = document.getElementById("lap");
        var a = document.createElement("div");
        a.id = "div1";
        a.innerHTML += "<table><tr><td width=65 align=center>" +
'Lap ' + (t[7]++) + "</td><td width=116 align=center>" +
format(t[3]) + "</td><td width=110 align=center>" +
format(t[1] - t[0]) + "</td></tr></table>";
        ttt.appendChild(a);
        t[4] = t[1] = t[0] = 0;
        disp();
    }
    else {
        t[4] = setInterval(disp, 43);
    }
}

function resetTimer() {
    t[4] = t[3] = t[2] = t[1] = t[0] = 0;
    document.getElementById('lap').innerHTML = '';
    startTimer();
    disp();
    t[7] = 1;
}

function disp() {
    if (t[2]) t[1] = (new Date()).valueOf();
    getElement.value = format(t[3] + t[1] - t[0]);
}

function format(ms) {
    var timerCounter = new Date(ms + DateTime).toString()
		.replace(/.*([0-9][0-9]:[0-9][0-9]:[0-9][0-9]).*/, '$1');
    var msZeros = String(ms % 1000);

    while (msZeros.length < 3) {
        msZeros = '0' + msZeros;
    }

    timerCounter += '.' + msZeros;

    return timerCounter;
}

function stopwatch() {
    DateTime = new Date(1970, 1, 1, 0, 0, 0, 0).valueOf();
    getElement = document.getElementById('disp');
    disp();
}