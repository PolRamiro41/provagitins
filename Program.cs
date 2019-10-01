using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcio =0;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("[1]  Buscamines");
                opcio = int.Parse(Console.ReadLine());
            }
            while (opcio != 0);
        }
    }
}
