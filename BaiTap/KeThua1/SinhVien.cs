using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua1
{
    public class SinhVien : Nguoi
    {
        public string MaSV;
        public int DTB;
        public string Email;

        public override void InputInfo()
        {
            base.InputInfo(); // base. gọi method InputInfo của lớp cha
            Console.Write("Nhap Vao Ma Sinh Vien: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap Vao Diem Trung Binh: ");
            DTB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Vao Email: ");
            Email = Console.ReadLine();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Ma Sinh Vien: " + MaSV);
            Console.Write("\nDiem Trung Binh: " + DTB);
            Console.Write("\nEmail: " + Email);
        }

        //hàm xét học bổng
        public void HocBong()
        {
            if (DTB > 8.5)
            {
                Console.WriteLine("\nHoc sinh duoc hoc bong" + Ten);
            }
        }
    }
}
