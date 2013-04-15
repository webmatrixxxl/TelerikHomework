namespace _02.RefactorCodeWellNamed2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HomoSapiens
    {
        public enum Gender
        {
            Male, Female
        }
   
        public static Human Create(int age)
        {
            Human newHuman = new Human();
            newHuman.Age = age;

            if (age % 2 == 0)
            {
                newHuman.Name = "Батката";
                newHuman.Sex = Gender.Male;
            }
            else
            {
                newHuman.Name = "Мацето";
                newHuman.Sex = Gender.Female;
            }

            return newHuman;
        }
      
        public static void Main(string[] args)
        {
            // Test the Human Class
            Human man = Create(10);
            Console.WriteLine("Name: {0} Age: {1} Sex: {2}", man.Name, man.Age, man.Sex);

            man = HomoSapiens.Create(11);
            Console.WriteLine("Name: {0} Age: {1} Sex: {2}", man.Name, man.Age, man.Sex);
        }

        public class Human
        {
            public Gender Sex { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
