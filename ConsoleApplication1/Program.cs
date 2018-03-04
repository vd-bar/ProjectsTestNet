using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            DateTime d = dt.AddHours(-2);
            string str = dt.ToString();
            DateTime dtt =Convert.ToDateTime(str);
            Console.WriteLine($"{d.ToString()}");
            Console.WriteLine($"{dtt}");
            Console.WriteLine($"{DateTime.Compare(dtt,d)}");
            int result = DateTime.Compare(d, dt);
            string relationship;
            if (result < 0)
                relationship = "is earlier than";
            else if (result == 0)
                relationship = "is the same time as";
            else
                relationship = "is later than";

            Console.WriteLine("{0} {1} {2}", d, relationship, dt);
            Console.ReadKey();
        }
    }
}
