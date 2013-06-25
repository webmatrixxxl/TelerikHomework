var Slider = (function () {
    var data = [];
    var direction = 1;
    var currentId = 0;
    var time = 5000;
    
    var controller = {
        init: function (selector) {
            that = this;
            this.wrapper = $(selector);
            this.btnRight = $('#btnRightDirection');
            this.btnRight.click(function () {
                that.changeDirection(1);
            });
            
            this.btnLeft = $('#btnLeftDirection');
            this.btnLeft.click(function () {
                that.changeDirection(-1);
            });
            
            var allitems = $('.item');
            for (var i = 0; i < allitems.length; i++) {
                if(i !== 0)
                    allitems[i].style.display = "none";
                data.push(allitems[i]);
            }
            that.slide();
        },
        duration: function(miliseconds) {
            time = miliseconds;
        },
        changeDirection: function (d) {
            direction = d;
        },
        slide: function () {
            var sliderPreview = $(data[currentId]);
            sliderPreview.delay(time).fadeOut("slow", function () {
                var temp = currentId + direction;
                if (temp < 0) {
                    temp = data.length - 1;
                }
                else if (temp === data.length) {
                    temp = 0;
                }
                currentId = temp;
                $(data[currentId]).fadeIn("slow", function () {
                    that.slide();
                });
            });
        },
    };

    var create = function() {
        return Object.create(controller);
    };
    
    return {
        create: create,
    };
})();