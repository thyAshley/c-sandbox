using System;
using System.Collections.Generic;
using System.Linq;

namespace ProceduralProgramming
{
    class Program
    {
        public static List<int> AddNumberToArray()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter Number or Quit to exit");
                var response = Console.ReadLine();
                if (response.Trim().ToLower() == "quit")
                {
                    break;
                }
                try
                {
                    numbers.Add(int.Parse(response));
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Number");
                }
            }
            return numbers;
        }
        public static List<int> GetUniqueList(List<int> numbers)
        {
            var uniqueList = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueList.Contains(number))
                {
                    uniqueList.Add(number);
                }
            }
            return uniqueList;
        }
        static void Main(string[] args)
        {
            var numbers = AddNumberToArray();
            var uniqueList = GetUniqueList(numbers);

            Console.WriteLine("Unique Numbers: ");
            foreach(var item in uniqueList)
            {
                Console.Write(item + ", ");
            }
        }


        
    }
}
