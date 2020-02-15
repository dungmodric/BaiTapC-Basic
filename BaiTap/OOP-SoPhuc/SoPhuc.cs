using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SoPhuc
{
    class SoPhuc
    {
        public float Thuc1;
        public float Ao1;
        public float Thuc2;
        public float Ao2;

        public SoPhuc() { }
        
        public void Input()
        {
            Console.Write("1 - Nhap gia tri cho phan thuc: ");
            Thuc1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("1 - Nhap gia tri cho phan ao: ");
            Ao1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 - Nhap gia tri cho phan thuc: ");
            Thuc2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 - Nhap gia tri cho phan ao: ");
            Ao2 = Convert.ToInt32(Console.ReadLine());
        }

        public void In()
        {
            Console.WriteLine(" So Phuc 1: " + Thuc1 + "+" + Ao1 + "i");
            Console.WriteLine(" So Phuc 2: " + Thuc2 + "+" + Ao2 + "i");
        }

        public void TinhToan()
        {
            Console.WriteLine("Cong 2 so phuc: " + (Thuc1 + Thuc2) + "+" + (Ao1 + Ao2) + "i");
            Console.WriteLine("Nhan 2 so phuc: " + (Thuc1 * Thuc2 - Ao1 * Ao2) + "+" + (Thuc1 * Ao2 + Thuc2 * Ao1) + "i");
            Console.WriteLine("Tru 2 so phuc: " + (Thuc1 - Thuc2) + "+" + (Ao1 - Ao2) + "i");
            Console.Write("Chia 2 so phuc: ");
            if(Thuc1 != 0 && Ao1 != 0)
            {
                Console.WriteLine(((Thuc1 * Thuc2 + Ao1 * Ao2) / (Thuc1 * Thuc1 + Ao1 * Ao1)) + "+" + ((Thuc1*Ao2 - Ao1*Thuc2)/(Thuc1*Thuc1 + Ao1*Ao1)) + "i");
            }
            else
            {
                Console.WriteLine("Phep chia khong thoa man!");
            }
        }
    }
}
