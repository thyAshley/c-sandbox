using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Composition;

namespace AccessModifier
{    

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
            var composition = new DbMigrator(new Logger());
        }
    }
}
