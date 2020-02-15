using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SoPhuc
{
    class Program
    {
        static void Main(string[] args)
        {
            SoPhuc sp = new SoPhuc();
            sp.Input();
            sp.In();
            sp.TinhToan();
            Console.ReadKey();
        }
    }
}
