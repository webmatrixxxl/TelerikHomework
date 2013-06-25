function Person(fname, lname) {
    var getFullname = function(){
             return fname + " " + lname;
    }

  this.introduce = function(){
    return "Hello! My name is " + getFullname();
  }
}

function Student(fname, lname, grade) {
    Person.apply(this, arguments);
    Person.call(this, fname, lname);

  this.getGrade = function(){
    return grade;
  }

  this.getFullname = function () {
      return "";
  }
}

Student.prototype = new Person();
Student.prototype.constructor = Student;

var cecoTroikata = new Student("Ceco", "Troikata", 3);

console.log("cecoTroikata instanceof Student? " + (cecoTroikata instanceof Student));
console.log("cecoTroikata instanceof Person? " + (cecoTroikata instanceof Person));
console.log("cecoTroikata is in " + cecoTroikata.getGrade() + " grade");
console.log(cecoTroikata.introduce());


