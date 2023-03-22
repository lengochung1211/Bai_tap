using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap2
{
    class Program
    {
        static void Main(string[] args)
        {
            float dai, rong;
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Nhap chieu dai hinh chu nhat : ");
            dai = float.Parse(Console.ReadLine());
            Console.WriteLine("Ban chon chieu dai la {0} cm", dai);

            Console.WriteLine("--------------------------------------------------");
            Console.Write("Nhap chieu rong hinh chu nhat : ");
            rong = float.Parse(Console.ReadLine());
            Console.WriteLine("Ban chon chieu rong la {0} cm", rong);

            Console.WriteLine("--------------------------------------------------");
            float dtich = dai * rong;
            Console.WriteLine("Dien tich hinh chu nhat la : {0} * {1} = {2} cm2", dai, rong, dtich);

            Console.WriteLine("--------------------------------------------------");
            float chuvi = (dai + rong) * 2;
            Console.WriteLine("Chu vi hinh chu nhat la : ({0} + {1}) * 2 = {2} cm", dai, rong, chuvi);


            Console.ReadKey();

        }
    }
}
