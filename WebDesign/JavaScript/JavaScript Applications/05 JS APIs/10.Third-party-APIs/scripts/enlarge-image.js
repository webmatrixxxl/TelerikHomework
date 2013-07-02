/// <reference path="external/jquery-2.0.2.js" />
 jQuery.fn.center = function () {
    this.css("position", "absolute");
    this.css("top", ($(window).height() - this.height()) / 2 + $(window).scrollTop() + "px");
    this.css("left", ($(window).width() - this.width()) / 2 + $(window).scrollLeft() + "px");
    return this;
}

var photos = (function () {
    $("#friends img").on('click', function (e) {

        $("#background").css({ "opacity": "0.7" })
                        .fadeIn("slow");

        $("#large").html("<img src='" + $(this).attr("src") + "' /><br/>" + $(this).attr("title") + "")
                   .center()
                   .fadeIn("slow");

        return false;
    });

    $(document).keypress(function (e) {
        if (e.keyCode == 27) {
            $("#background").fadeOut("slow");
            $("#large").fadeOut("slow");
        }
    });

    $("#background").click(function () {
        $("#background").fadeOut("slow");
        $("#large").fadeOut("slow");
    });

    $("#large").click(function () {
        $("#background").fadeOut("slow");
        $("#large").fadeOut("slow");
    });
});