using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap3
{
    class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.14f;
            float duong_kinh, ban_kinh, chu_vi, dien_tich;
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Nhap vao duong kinh hinh tron : ");
            duong_kinh = float.Parse(Console.ReadLine());
            Console.WriteLine("Ban chon duong kinh hinh tron la : {0} cm", duong_kinh);

            Console.WriteLine("--------------------------------------------------");
            ban_kinh = duong_kinh / 2;
            Console.WriteLine("Ban kinh hinh tron la : {0} / 2 = {1} cm", duong_kinh, ban_kinh);

            Console.WriteLine("--------------------------------------------------");
            chu_vi = 2 * PI * ban_kinh;
            Console.WriteLine("Chu vi hinh tron la : 2 * 3,14 * {0} = {1} cm", ban_kinh, chu_vi);

            Console.WriteLine("--------------------------------------------------");
            dien_tich = PI * ban_kinh * ban_kinh;
            Console.WriteLine("Dien tich hinh tron la : 3,14 * {0} * {1} = {2} cm2", ban_kinh, ban_kinh, dien_tich);

            Console.ReadKey();


        }
    }
}
