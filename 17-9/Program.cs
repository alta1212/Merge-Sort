using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Bai2
    {
        //Bai 2: Cho dãy n số nguyên a0,a1,...,an-1. 
        //Hãy chuyển k phần tử đầu tiên của dãy về cuối dãy.
        static void Main(string[] args)
        {
            b2();
            Console.ReadKey();
        }

        //BÀI 2
        public static void b2()
        {
            int[] arr = new int[20];
            Random ran = new Random();
            for (int i = 0; i <= 20; i++)
            {
                arr[i] = ran.Next(1, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nnhập k là số phần tử muốn chuyển (nhỏ hơn 20)");
            int k = int.Parse(Console.ReadLine());
            int[] arr2 = new int[20];
            int[] arr3 = new int[k];
            int s = 0;

            //mảng gốc,index phần tử đầu muốn lấy,mảng được copy,index vị trí mảng muốn copy,số phần tử cần copy
            Array.Copy(arr, 0, arr3, 0, k);
            Array.Copy(arr, k, arr2, 0, 20 - k);


            s = 0;

            for (int f = 20 - k; f <= 20; f++)
            {
                arr2[f] = arr3[s];
                s++;
            }

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(arr2[i] + " ");

            }
        }
    }
}