using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanHoaChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // BÀI 2: CHUẨN HÓA CHUỖI ------------------------------------------------------------
            Console.Write("Nhap chuoi: ");
            string n = Console.ReadLine();
            n = n.Trim().ToLower();
            while (n.Contains("  "))
                n = n.Replace("  ", " ");
            string ketqua = "";
            string[] a = n.Split(' ');
            foreach (string i in a)
            {
                ketqua += i.Substring(0, 1).ToUpper() + i.Substring(1) + " ";
            }
            Console.Write("Chuoi duoc chuan hoa: " + ketqua.TrimEnd()) ;
            Console.ReadKey();
        }
    }
}
