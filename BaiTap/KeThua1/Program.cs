using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua1
{
    class Program
    {
        static void Main(string[] args)
        {
            // PHẦN 1 + 2

            //Nguoi ng = new Nguoi();
            //SinhVien sv = new SinhVien();
            //ng.InputInfo();
            //ng.ShowInfo();
            //sv.InputInfo();
            //sv.ShowInfo();
            //sv.HocBong();
            //Console.ReadKey();

            // PHẦN 3

            // Khởi tạo 1 List sinh viên rỗng
            List<SinhVien> sv = new List<SinhVien>();
            int menu, DTBMax, DTBMin;
            do
            {
                Console.WriteLine("\nChon menu tu 1 --> 6: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Write("So luong sinh vien can nhap: ");
                        int solgSV = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < solgSV; i++)
                        {
                            SinhVien SV = new SinhVien();
                            SV.InputInfo();
                            sv.Add(SV);
                        }
                        break;
                    case 2:
                        // In danh sách trong List
                        if (sv.Count != 0)
                        {
                            foreach (var i in sv)
                            {
                                i.ShowInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Khong co sinh vien !");
                        }
                        break;
                    case 6:
                        Console.Write("Thoat !");
                        break;
                }
            } while (menu != 6);
            Console.ReadKey();
        }
    }
}
