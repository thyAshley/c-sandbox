using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name:");
            var name = Console.ReadLine();

            Console.WriteLine(ReverseName(name));
        }

        public static string ReverseName(string name)
        {
            var array = name.ToCharArray();
            return String.Join("", array.Reverse());
        }
        
    }
}
