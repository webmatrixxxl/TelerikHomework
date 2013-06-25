var Class = (function() {
  function createClass(properties) {
      var f = function () {
          //This is an addition to enable super (base) class with inheritance
        if(this._superConstructor){
            this._super = new this._superConstructor(arguments);
            }
      this.init.apply(this, arguments);
    }
    for (var prop in properties) {
      f.prototype[prop] = properties[prop];
    }
    if (!f.prototype.init) {
      f.prototype.init = function() {}
    }
    return f;
  }

  Function.prototype.inherit = function(parent) {
    var oldPrototype = this.prototype;
    this.prototype = new parent();
    this.prototype._superConstructor = parent;
    for (var prop in oldPrototype) {
      this.prototype[prop] = oldPrototype[prop];
    }
  }

  return {
    create: createClass,
  };
}());

var Person = Class.create({
  init: function(fname, lname, nickname) {
    this.fname = fname;
    this.lname = lname;
    this.nickname = nickname;
  },
  toString: function() {
    return "Name: " + this.fname + " " + this.lname + ", aka. " + this.nickname;
  }
});

var Student = Class.create({
    init: function (fname, lname, nickname, grade) {

    this._super.init(fname, lname, nickname);
    this.grade = grade;
  },
  getGrade: function() {
    return this.grade;
  },
  toString: function() {
    return this._super.toString() + ", in " + this.grade + " grade";
  }
});

Student.inherit(Person);

var pesho = new Student("Peter", "Petrov", "Pesho Vodkata", 3);
var gosho = new Student("Gosho", "Goshov", "Goshoto", 5);
console.log(pesho.toString());
console.log(pesho instanceof Student);
console.log(pesho instanceof Person);