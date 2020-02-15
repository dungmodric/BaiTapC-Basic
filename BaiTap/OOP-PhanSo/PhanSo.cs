using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PhanSo
{
    class PhanSo
    {
        public float TuSo1;
        public float MauSo1;
        public float TuSo2;
        public float MauSo2;
        
        public PhanSo() { }
        public void Input()
        {
            Console.Write("1 - Nhap gia tri cho tu so: ");
            TuSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("1 - Nhap gia tri cho mau so: ");
            MauSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 - Nhap gia tri cho tu so: ");
            TuSo2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 - Nhap gia tri cho mau so: ");
            MauSo2 = Convert.ToInt32(Console.ReadLine());
        }

        public void In()
        {
            Console.WriteLine(" Phan So 1: {0} ", (TuSo1 / MauSo1));
            Console.WriteLine(" Phan So 2: {0}  ", (TuSo2 / MauSo2));
        }

        public void TinhToan()
        {
            Console.WriteLine("Cong 2 phan so: {0}", ((TuSo1 / MauSo1) + (TuSo2 / MauSo2)));
            Console.Write("Tru 2 phan so: ");
            if((TuSo1 / MauSo1) > (TuSo2 / MauSo2))
            {
                Console.WriteLine((TuSo1 / MauSo1) - (TuSo2 / MauSo2));
            }
            else
            {
                Console.WriteLine((TuSo2 / MauSo2) - (TuSo1 / MauSo1));
            }
            Console.WriteLine("Nhan 2 phan so: {0}", ((TuSo1 / MauSo1) * (TuSo2 / MauSo2)));
            Console.WriteLine("Chia 2 phan so: {0}", ((TuSo1 / MauSo1) / (TuSo2 / MauSo2)));
        }
    }
}
