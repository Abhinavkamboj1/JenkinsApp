using System;
using MyMth;
namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcom to Jenkins");
            

            Class1 math = new Class1();
            double Add = math.Add(34.5, 54.6);
            double Sub = math.Sub(56.3, 65.7);

            Console.WriteLine("Maths Function");

            Console.WriteLine(Add);
            Console.WriteLine(Sub);

            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
