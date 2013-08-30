/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
WinJS.Namespace.define(
    "Plants",
    {

    Vegetable: WinJS.Class.define(
         //constructor 

        function (name, color, directlyEaten) {
            this.name = name;
            this.color = color;
            this.directlyEaten = directlyEaten;
        },
     //instance Members
    {
        info: function () {
            console.log("Plant: " + this.name);
            console.log("Color: " + this.color);
            console.log("Can be eaten directly? -> " + this.directlyEaten);
        }
    },
      //static members
    {}
    ),

    Cucumber: WinJS.Class.derive(Vegetable, function (name, length) {
        Vegetable.call(this, name, "Зелен", false);
        this.length = length;
    }),

});                                                                                             

WinJS.Namespace.defineWithParent(Plants, "Vegetables",
    {
        Tomato: WinJS.Class.derive(
             //base class
            Plants.Vegetable,

             //constructor
            function (name, radios) {
                Plants.Vegetable.apply(this, [name, "Червен", true]);
                this.radios = radios;
            },

             //instance members
            {
                info: function () {
                    console.log("Radios: " + this.radios);
                }
            }),
    });

WinJS.Namespace.define("Mixins", {

    MushroomMixin: {
        grow: function (waterLiters) {
            this.size += waterLiters;
        }
    }
});


WinJS.Namespace.define("VegetableGmos", {
    TomatoGmo: WinJS.Class.mix(Plants.Vegetables.Tomato, Mixins.MushroomMixin)
});

WinJS.Namespace.define("VegetableGmos", {
    TomatoGmo: WinJS.Class.mix(Plants.Vegetables.Tomato, Mixins.MushroomMixin)
});

WinJS.Namespace.define("VegetableGmos", {
    CucumberGmo: WinJS.Class.mix(Plants.Vegetables.Cucumber, Mixins.MushroomMixin)
});