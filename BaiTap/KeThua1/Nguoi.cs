using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua1
{
    public class Nguoi
    {
        public string Ten;
        public string GioiTinh;
        public string NgaySinh;
        public string DiaChi;
        
        // hàm khởi tạo không tham số
        public Nguoi() { }

        //hàm khởi tạo đầy đủ tham số
        public Nguoi(string Ten, string GioiTinh, string NgaySinh, string DiaChi)
        {
            this.Ten = Ten;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
        }

        public virtual void InputInfo()
        {
            Console.Write("Nhap Ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap Gioi Tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap Ngay Sinh: ");
            NgaySinh = Console.ReadLine();
            Console.Write("Nhap Dia Chi: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Gioi Tinh: " + GioiTinh);
            Console.WriteLine("Ngay Sinh: " + NgaySinh);
            Console.WriteLine("Dia Chi: " + DiaChi);
        }
    }
}
