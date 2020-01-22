using System;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            age = 27;
            height = 72;
            int maxheartrate = 220 - age;

            Console.WriteLine("I am " + age + "years old, my max heart rate is " + maxheartrate + " and I am " + height + " inches tall");
         
        }
    }
}
