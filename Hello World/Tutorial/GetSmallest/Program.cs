using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 6,5,4,3,2,1,6 };
            var smallests = GetSmallests(numbers, 12);

            foreach (var number in smallests)
            { 
                Console.WriteLine(number);
            }
        }

        public static int GetSmallest(List<int> list)
        {
            return list[0];
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            var buffer = new List<int>(list);
            buffer.Sort();
            var smallestList = new List<int>();
            while (smallestList.Count < count && buffer.Count != 0 )
            {
                var smallest = GetSmallest(buffer);
                smallestList.Add(smallest);
                buffer.Remove(smallest);
            }
            return smallestList;
        }
    }
}
