using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;

            Console.WriteLine("Hello, world! Say something.");
            UserInput = Console.ReadLine();
            Console.WriteLine(UserInput);
            Console.WriteLine("Press any key to end program.");
            Console.ReadLine();
        }
    }
}
