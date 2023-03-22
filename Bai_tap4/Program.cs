using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap4
{
    class Program
    {
        static void Main(string[] args)
        {
            string hoTen, lop;
            float tb_hki, tb_hkii;
            double  tb_canam;
            Console.WriteLine("        Thong tin hoc sinh trung hoc");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Ho va ten            : ");
            hoTen = Console.ReadLine();

            Console.Write("Lop                  : ");
            lop = Console.ReadLine();

            Console.Write("Diem trung binh HKI  : ");
            tb_hki = float.Parse (Console.ReadLine());

            Console.Write("Diem trung binh HKII : ");
            tb_hkii = float.Parse (Console.ReadLine());

            Console.WriteLine("-------------------------------------------");
            tb_canam = Math .Round ( (tb_hki + tb_hkii * 2) / 3, 1);
            Console.WriteLine("Diem trung binh ca nam : {0}", tb_canam);

            Console.ReadKey();

        }
    }
}
