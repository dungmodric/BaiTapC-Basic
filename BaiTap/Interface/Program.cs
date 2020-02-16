using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang A: ");
            int n = Convert.ToInt32(Console.ReadLine());
            DaySo ds = new DaySo();
            ds.DaySo1(n);
            Console.ReadKey();
        }
    }
}
