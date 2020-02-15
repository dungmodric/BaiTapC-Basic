using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangHaiChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            // KHAI BÁO MẢNG VÀ IN -------------------------------------------
            int hang, cot, i, j, tmp;
            Console.Write("Nhap so hang : ");
            hang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot : ");
            cot = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[cot, hang];
            for(i = 0; i < cot; i++)
            {
                for(j = 0; j < hang; j++)
                {
                    Console.Write("Nhap phan tu ({0} , {1}) ", (i+1), (j+1));
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nMang ban vua nhap la: \n");
            for (j = 0; j < hang; j++)
            {
                for (i = 0; i < cot; i++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }

            // SẮP XẾP GIÁ TRỊ TRONG TỪNG CỘT GIẢM DẦN------------------------------
            int k;
            for (i = 0; i < cot; i++)
            {
                for (j = 0; j < hang; j++)
                {
                    for (k = 0; k < j; k++)
                    {
                        if (A[i, j] > A[i, k])
                        {
                            tmp = A[i, j];                   //trao đổi giá trị
                            A[i, j] = A[i, k];
                            A[i, k] = tmp;
                        }
                    }
                }
            }
            Console.WriteLine("Sap xep gia tri trong tung cot giam dan: ");
            for (j = 0; j < hang; j++)
            {
                for (i = 0; i < cot; i++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
            // SẮP XẾP GIÁ TRỊ TRONG TỪNG HÀNG TĂNG DẦN------------------------------
            
            for (j = 0; j < hang; j++)
            {
                for (i = 0; i < cot; i++)
                {
                    for (k = i + 1; k < cot; k++)
                    {
                        if (A[i, j] > A[k, j])
                        {
                            tmp = A[i, j];
                            A[i, j] = A[k, j];
                            A[k, j] = tmp;
                        }
                    }

                }
            }
            Console.WriteLine("Sap xep gia tri trong tung hang tang dan: ");
            for (j = 0; j < hang; j++)
            {
                for (i = 0; i < cot; i++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
