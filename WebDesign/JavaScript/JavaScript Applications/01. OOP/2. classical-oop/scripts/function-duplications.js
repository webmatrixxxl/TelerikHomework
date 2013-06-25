function Person(fname, lname) {
  this.introduce = function() {
    return "Hello! My name is " + fname + " " + lname;
  }
}

function Student(fname, lname, grade) {
    this._fname = fname;
  Person.apply(this, arguments);

  this.getGrade = function() {
    return grade;
  }
}

Student.prototype = new Person();
Student.prototype.constructor = Student;

var cecoTroikata = new Student("Ceco", "Troikata", 3);
var mitkoZubara = new Student("Mitko", "Zubara", 6);

Student.prototype.speak = function (text) {
    return this.fname + ": " + text;
}

//The methods have different instances, so they are both created in memory
console.log(cecoTroikata.getGrade === mitkoZubara.getGrade);
console.log(cecoTroikata.introduce === mitkoZubara.introduce);
console.log(cecoTroikata.speak("hello"));