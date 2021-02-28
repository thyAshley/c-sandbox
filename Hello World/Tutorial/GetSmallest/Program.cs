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
            var smallests = GetSmallests(numbers, 3);

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
            list.Sort();
            var smallestList = new List<int>();
            while (smallestList.Count < count)
            {
                var smallest = GetSmallest(list);
                smallestList.Add(smallest);
                list.Remove(smallest);
            }
            return smallestList;
        }
    }
}
