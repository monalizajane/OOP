using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_CaO
{
    internal class Program
    {
        //Name: Monaliza Jane Sibomit
        //Section: IT306

        //EXER_01: Creating a Class
        static void Main(string[] args)
        {
            //instantiation of an object
            Person person1 = new Person();

            ////initialization of fields
            person1.name = "Monaliza Jane";
            person1.age = 22;
            person1.gender = "bisexual";

            //call the method
            person1.Greet();

            Console.ReadKey();
        }
    }
}
