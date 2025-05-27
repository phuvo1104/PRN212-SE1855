using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public static class MyUtils
    {
        /*Cau mot cai 1 ham tong tu 1 den N
          */
        public static int TongTu1DenN(this int n)
        { 
            int sum =0;
            for (int i = 1;1<=n;i++)
            {
                sum += i;
            }
            return sum; 
        }
        public static int Cong(this int a, int b)
        { 
            return a + b;
        }
        public static void SapXepTangDan(this int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0;j<arr.Length;j++)
                {
                    int temp=arr[i];
                    arr[j]=arr[i];
                    arr[j]=temp;
                }
            }
        }
    }
}
