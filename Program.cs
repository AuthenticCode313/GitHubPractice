using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user infor and displayed it
            Console.WriteLine("What is you name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age? ");
            string age = Console.ReadLine();
            int ageF = int.Parse(age);
            Console.WriteLine("What is your favorite color? ");
            string color = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(color); 

              

        }
    }
}
