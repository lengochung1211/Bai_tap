using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nhap so nguyen duong a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ban chon so duong a = {0}", a);

            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nhap so nguyen duong b : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ban chon so duong b = {0}", b);

            Console.WriteLine("-------------------------------------------------");
            int tong = a + b;
            Console.WriteLine("Tong cua hai so duong la : {0} + {1} = {2}", a, b, tong);

            Console.WriteLine("-------------------------------------------------");
            int hieu = a - b;
            Console.WriteLine("Hieu cua hai so duong la : {0} - {1} = {2}", a, b, hieu);

            Console.WriteLine("-------------------------------------------------");
            int tich = a * b;
            Console.WriteLine("Tich cua hai so duong la : {0} * {1} = {2}", a, b, tich);

            Console.WriteLine("-------------------------------------------------");
            float thuong = a * 1f / b;
            Console.WriteLine("Thuong cua hai so duong la : {0} / {1} = {2}", a, b, thuong);


            Console.ReadKey();
        }
    }
}
