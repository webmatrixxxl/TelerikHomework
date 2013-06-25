function Proportions(bust, waist, hip) {
    this.bust = bust;
    this.waist = waist;
    this.hip = hip;
}

Proportions.prototype.toString = function () {
    return this.bust + " " + this.waist + " " + this.hip;
}

function Person( lname) {
  this.lname = lname;
}

Person.prototype.proportions = new Proportions(90, 60, 90);

Person.prototype.fname = new String("");

Person.prototype.introduce = function() {
  return "Hello! My name is " + this.fname + " " + this.lname + " I am " + this.proportions ;
}

function Student(fname, lname, grade) {
  Person.apply(this, arguments);
  this.grade = grade;
}

Student.prototype = new Person();
Student.prototype.constructor = Student;

Student.prototype.getGrade = function() {
  return grade;
}

var cecoTroikata = new Student("Ceco", "Troikata", 3);
var mitkoZubara = new Student("Mitko", "Zubara", 6);

//The methods are identical and they are created only once in memory
console.log(cecoTroikata.getGrade === mitkoZubara.getGrade);
console.log(cecoTroikata.introduce === mitkoZubara.introduce);

mitkoZubara.proportions = new Proportions(10, 10, 10);
 
console.log(cecoTroikata.introduce());
console.log(mitkoZubara.introduce());