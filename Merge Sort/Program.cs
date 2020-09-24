using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string continu = "";
            while(continu=="")
            {  int[] k = new int[10];
            Random n = new Random();
            for (int i=0;i<10;i++)
            {
                k[i] = n.Next(1, 1000);
            }
               mergesort(k, 0, k.Length-1);
            
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(k[i]);
            }
                continu = Console.ReadLine();
                Console.Clear();
            }    
          
            Console.ReadKey();
        }
        static void merge(int [] arr, int l,int m,int h)//m:phần tử  mid
        {
            int i, j, k =l;
            int n1 = m - l + 1;//tìm số phần tử cho mảng 1 sau chia đôi
            int n2 = h - m;//tìm số phần tử cho mảng 2 sau chia đôi

            int[] left = new int[n1];
            int[] right = new int[n2];
            for(i=0;i<n1;i++)
            {
                left[i] = arr[l + i];//
            }
            for (j = 0; j < n2; j++)
            {
                right[j] = arr[m + j+1];//
            }
            //trộn 
            i =0;j = 0;
            while(i<n1&&j<n2)
            {
                arr[k++] = (left[i] <= right[j]) ? left[i++] : right[j++];//? = if() nếu dúng lấy sau dấu ? nếu sai lấy sau :
                
            }   
            //sau khi chạy có thể mảng 1 và 2 chưa chạy hết phần tử nên phải chạy thêm 
            while(i<n1)
            {
                arr[k++] = left[i++];
            }    
            while(j<n2)
            {
                arr[k++] = right[j++];
            }    
        }
        static  void mergesort(int [] arr,int l,int h)//l:low số tt phần tử đầu cho mảng hiện thời
        {                                     //h:hight số tt phần tử cuối cho mảng hiện thời
            /*1 tìm phần tử mid
              2 đệ quy nửa trước
              3 đệ quy nửa sau
              4 trộn 2 mảng lại thành kết quả*/
            if (l<h)
            {
                int m = l + (h - l) / 2;
                mergesort(arr,l,m);
                mergesort(arr, m + 1, h);
                merge(arr, l, m, h);
            }    
        }
    }
}
