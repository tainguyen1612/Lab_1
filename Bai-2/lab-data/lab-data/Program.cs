using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_data
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n;
            int[] array = new int[10];
            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 50);
                Console.Write("{0} ",array[i]);
            }
            chen_mang(array , n);
            xoa_mang(array, n);
            getSo(array, n);

            Console.ReadLine();
           
        }
        static void getSo(int[] arr , int n)
        {
            Console.Write("\nNhap so can tim: ");
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<=n;i++)
            {
                if(arr[i] == p)
                {
                    Console.WriteLine("So {0} nam o vi tri {1}",p,i+1);
                }
                else
                {
                    Console.WriteLine("Khong co pha tu {0} trong mang",p);
                    return;
                }
            }
        }
        static void chen_mang(int[] arr,int n)
        {
            Console.Write("\nNhap gia tri phan tu moi can chen: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap vi tri can chen phan tu moi nay: ");
            int p = Convert.ToInt32(Console.ReadLine());
            if(arr.Length > p)
            {
                // di chuyen vi tri cac phan tu ben phai cua mang 
                for (int i = n; i >= p; i--)
                {
                    arr[i] = arr[i - 1];

                }
                //chen gia tri vao vi tri da cho 
                arr[p - 1] = x;
                Console.Write("\nSau khi chen phan tu, mang co dang:\n");
                for (int i = 0; i <= n; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Qua do dai phan tu cua mang");
            }
                
            Console.WriteLine();
        }

        static void xoa_mang(int[] arr , int n)
        {
            Console.Write("\nNhap vi tri can xoa: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            // xac dinh vi tri cua i trong mang
            int i = 0;
            while (i != pos - 1)
            {
                if(arr.Length>pos)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("qua do dai can xoa");
                    return;
                }
            }
            
            //vi tri i trong mang se duoc thay the boi gia tri ben phai cua no 
            while (i < n)
            {
                arr[i] = arr[i + 1];
                i++;
            }
            n--;
            Console.Write("\nIn mang sau khi da xoa phan tu : ");
            for (i = 0; i <=n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
