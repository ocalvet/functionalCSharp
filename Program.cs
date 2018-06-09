using System;

namespace functionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = Who();
            Console.WriteLine($"{name} you are {age} years old");
        }
        public static (string name, int age) Who() {
            return ("Ovidio", 23);
        }
    }

}
