using System;
using System.Collections.Generic;

namespace Indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Ash";
            Console.WriteLine(cookie["name"]);

            var test = new Dictionary<string, string>();
            test["tes"] = "ahe";
        }
    }
}
