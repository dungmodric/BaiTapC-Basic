using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua1
{
    class GiaoVien : Nguoi
    {
        public string GV_Ma;
        public double GV_Luong1h;
        public int GV_sogio;
        public int GV_thamnien;

        public override void InputInfo()
        {
            base.InputInfo(); // base. gọi method InputInfo của lớp cha
            Console.Write("Nhap ma giao vien: ");
            GV_Ma = Console.ReadLine();
            Console.Write("Nhap luong 1 gio: ");
            GV_Luong1h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so gio lam trong thang: ");
            GV_sogio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nam lam viec: ");
            GV_thamnien = Convert.ToInt32(Console.ReadLine());
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Ma giao vien: " + GV_Ma);
            Console.Write("\nLuong trong 1h: " + GV_Luong1h);
            Console.Write("\nSo gio lam trong thang: " + GV_sogio);
            Console.Write("\nSo nam lam viec: " + GV_thamnien);
        }

        public double LuongNhan()
        {
            if (GV_thamnien < 1)
            {
                return (GV_Luong1h * GV_sogio);
            }
            else if (GV_thamnien < 3)
            {
                return (GV_Luong1h * GV_sogio * 1.1);
            }
            else if (GV_thamnien < 5)
            {
                return (GV_Luong1h * GV_sogio * 1.3);
            }
            else 
            {
                return (GV_Luong1h * GV_sogio * 1.5);
            }
        }
    }
}
