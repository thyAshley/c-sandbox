using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Tester
    {

    }

    public class Installer
    {
        private readonly Logger _logger;
        private readonly Tester _test;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public Installer (Tester test)
        {
            _test = test;
        }
        public void Install()
        {
            _logger.Log("We are installing the application..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(new Logger());

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
