using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class DaySo
    {
        int i;
        public void Nhap() 
        {
            Console.Write("Nhap phan tu thu {0}: ", i);
            Convert.ToInt32(Console.ReadLine());
        }

        public void Print(int[] A)
        {
            foreach (var a in A)
            {
                Console.Write(a);
            }
        }

        public void DaySo1(int n)
        {
            int[] A = new int[n];
            for (i = 1; i <= n; i++)
            {
                Nhap();
            }
        }
    }
}
