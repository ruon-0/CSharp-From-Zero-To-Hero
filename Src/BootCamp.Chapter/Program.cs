using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "";
            var surename = "";
            var age = "";
            var weight = "";
            var height = "";

            Console.WriteLine("Hello World! This is my first homework assignment. Let's go!");
            Console.WriteLine("\nPlease put the following information in:");
            //Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Surname: ");
            surename = Console.ReadLine();
            Console.Write("Age: ");
            age = Console.ReadLine();
            Console.Write("Weight in kg: ");
            weight = Console.ReadLine();
            Console.Write("Height in cm: ");
            height = Console.ReadLine();

            Console.WriteLine("\nWell done. Let's see who we got");
            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight
                + " kg and his height is " + height + " cm.");
            Console.WriteLine(name + "'s BMI is = " + Math.Round(10000 * (float.Parse(weight) / Math.Pow(float.Parse(height),2)),2));

            Console.WriteLine("\nThat was fun, let's do another one!");
            Console.WriteLine("\nPlease put the following information in:");

            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Surname: ");
            surename = Console.ReadLine();
            Console.Write("Age: ");
            age = Console.ReadLine();
            Console.Write("Weight in kg: ");
            weight = Console.ReadLine();
            Console.Write("Height in cm: ");
            height = Console.ReadLine();

            Console.WriteLine("\nWell done. Let's see who we got");
            Console.WriteLine("\n" + name + " " + surename + " is " + age + " years old, his weight is " + weight
                + " kg and his height is " + height + " cm.");
            Console.WriteLine(name + "'s BMI is = " + Math.Round(10000 * (float.Parse(weight) / Math.Pow(float.Parse(height), 2)), 2));

        }
    }
}
