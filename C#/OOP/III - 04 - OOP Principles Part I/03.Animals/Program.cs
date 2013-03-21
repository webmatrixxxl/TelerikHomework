using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//  Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
//  Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female
//  and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of
//  animals and calculate the average age of each kind of animal using a static method (you may use LINQ).


namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Sharo = new Dog(10, "Sharo", Sex.Male, "bao lau");
            Console.WriteLine(Sharo);
            Animal[] Animals = new Animal[] {

            new Tomcat(15, "Маци", "miau"),
            new Tomcat(11, "Котан", "miau miau"),
            new Tomcat(1, "Джери", "bau miau"),
            
        };

            Cat[] cats = new Cat[]
        {
            new PussyCat(1, "Мац", "bau miau"),
            new Tomcat(2, "Тим", "bau miau"),

        };

            Console.WriteLine("# Animals");
            foreach (Animal animal in Animals)
                Console.WriteLine(animal);




            Console.WriteLine("# Average");
            Console.WriteLine(Animals.Average(animal => animal.age));
            Console.WriteLine(cats.Average(cat => cat.age));
        }
    }
}
