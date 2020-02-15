using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangMotChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            // TÌM SỐ LỚN NHẤT, NHỎ NHẤT VÀ VỊ TRÍ ----------------------------------------------------

            Console.Write("Nhap so phan tu cho mang: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] A = new int[a];
            for (i = 0; i < a; i++)
            {
                Console.Write("Nhap so thu {0}:", (i+1) );
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nMang ban vua nhap la: ");
            for (i = 0; i < a; i++)
            {
                Console.Write("{0}  ", A[i]);
            }
            Console.Write("\n");

            int max = A[0], min = A[0], vitriMax = 0, vitriMin = 0;
            for (i = 0; i < a; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
            }
            for(i = 0; i < a; i++)
            {
                if(A[i] == max)
                {
                    vitriMax = i;
                }
                if (A[i] == min)
                {
                    vitriMin = i;
                }
            }
            Console.Write("\nSo lon nhat trong mang la " + max + " la so thu " + (vitriMax + 1) + "\n");
            Console.Write("\nSo nho nhat trong mang la " + min + " la so thu " + (vitriMin + 1) + "\n");

            // SẮP XẾP TĂNG, GIẢM -------------------------------------------------------------------------
            // GIẢM
            int tmp, j;
            for (i = 0; i < a; i++)
            {
                for (j = i + 1; j < a; j++)
                {
                    if (A[i] < A[j])
                    {
                        tmp = A[i];                   //trao đổi giá trị
                        A[i] = A[j];
                        A[j] = tmp;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu giam dan: ");
            for (i = 0; i < a; i++)
            {
                Console.Write("{0}  ", A[i]);
            }
            Console.Write("\n");

            // TĂNG
            for (i = 0; i < a; i++)
            {
                for (j = i + 1; j < a; j++)
                {
                    if (A[i] > A[j])
                    {
                        tmp = A[i];                  //trao đổi giá trị
                        A[i] = A[j];
                        A[j] = tmp;
                    }
                }
            }
            Console.Write("\nIn cac phan tu mang theo thu tu tang dan: ");
            for (i = 0; i < a; i++)
            {
                Console.Write("{0}  ", A[i]);
            }
            Console.ReadKey();
        }
    }
}
