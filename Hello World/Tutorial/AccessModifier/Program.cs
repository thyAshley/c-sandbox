using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new System.DateTime(1991, 1, 1));
            System.Console.WriteLine(person.Age);

        }
    }
}
