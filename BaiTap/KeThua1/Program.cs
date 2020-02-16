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
            //List<SinhVien> sv = new List<SinhVien>();
            //int menu, DTBMax, DTBMin;
            //do
            //{
            //    Console.WriteLine("\nChon menu tu 1 --> 6: ");
            //    menu = Convert.ToInt32(Console.ReadLine());
            //    switch (menu)
            //    {
            //        case 1:
            //            Console.Write("So luong sinh vien can nhap: ");
            //            int solgSV = Int32.Parse(Console.ReadLine());
            //            for (int i = 0; i < solgSV; i++)
            //            {
            //                SinhVien SV = new SinhVien();
            //                SV.InputInfo();
            //                sv.Add(SV);
            //            }
            //            break;
            //        case 2:
            //            // In danh sách trong List
            //            if (sv.Count != 0)
            //            {
            //                foreach (var i in sv)
            //                {
            //                    i.ShowInfo();
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Khong co sinh vien !");
            //            }
            //            break;
            //        case 3:
            //            DTBMax = sv.Max(n => n.DTB);
            //            DTBMin = sv.Min(n => n.DTB);
            //            var svMaxScore = sv.Where(n => n.DTB == DTBMax).FirstOrDefault();
            //            svMaxScore.ShowInfo();
            //            var svMinScore = sv.Where(n => n.DTB == DTBMin).FirstOrDefault();
            //            svMinScore.ShowInfo();
            //            break;
            //        case 4:
            //            Console.Write("Nhap ma sinh vien");
            //            string MaSV = Console.ReadLine();
            //            var sinhvien = sv.FirstOrDefault(n => n.MaSV == MaSV);
            //            if (sinhvien == null)
            //            {
            //                Console.Write("\nKhong ton tai sinh vien co ma la {0}", MaSV);
            //            }
            //            else
            //            {
            //                sinhvien.ShowInfo();
            //            }
            //            break;
            //        case 5:
            //            var listSinhVien = sv.Where(n => n.DTB > 8.5).OrderByDescending(n => n.DTB).ToList();
            //            foreach (var i in listSinhVien)
            //            {
            //                i.ShowInfo();
            //            }
            //            break; 
            //        case 6:
            //            Console.Write("Thoat !");
            //            break;
            //    }
            //} while (menu != 6);
            //Console.ReadKey();

            // PHẦN 4
            //Khởi tạo 1 List giáo viên rỗng
            List<GiaoVien> gv = new List<GiaoVien>();
            int menu;
            do
            {
                Console.WriteLine("\nChon menu tu 1 --> 4: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Write("So luong giao vien can nhap: ");
                        int solgGV = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < solgGV; i++)
                        {
                            GiaoVien GV = new GiaoVien();
                            GV.InputInfo();
                            gv.Add(GV);
                        }
                        break;
                    case 2:
                        // In danh sách trong List
                        if (gv.Count != 0)
                        {
                            foreach (var i in gv)
                            {
                                i.ShowInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Khong co giao vien !");
                        }
                        break;
                    case 3:
                        double a = gv.Max(n => n.LuongNhan());
                        var GV_LuongMax = gv.Where(n => n.LuongNhan() == a).FirstOrDefault();
                        GV_LuongMax.ShowInfo();
                        break;
                    case 4:
                        Console.Write("Thoat !");
                        break;
                }
            } while (menu != 4);
            Console.ReadKey();
        }
    }
}
