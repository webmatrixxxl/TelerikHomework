function Person(fname, lname) {

    var fullname = fname + " " + lname;

  this.introduce = function(){
    return "Hello! My name is " + fname + " " + lname;
  }

  this.getFullname = function () {
      return fullname;
  }
}

Person.prototype.speak = function (text) {
    return this.getFullname() + ": " + text;
}

var joro = new Person("Joro", "Mentata");
var pesho = new Person("Pesho", "Vodkata");
console.log(joro.introduce()); 
//logs "Hello! My name is Joro Mentata"
console.log(pesho.introduce());

console.log(pesho.speak("Hello"));