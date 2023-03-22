using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap5
{
    struct ThongTinnhanvien
    {
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }

        public float HSL { get; set; }
        public int LCB { get; set; }
        public int soNam { get; set; }
        public int PC { get; set; }
        public int tamTinh { get; set; }
        public int Luong { get; set; }
        public ThongTinnhanvien(string ten, string gt, DateTime ns, float hsl, int lcb, int sonam)
        {
            this.hoTen = ten;
            this.gioiTinh = gt;
            this.ngaySinh = ns;
            this.HSL = hsl;
            this.LCB = lcb;
            this.soNam = sonam;
            this.PC = sonam >= 5 ? lcb /2 : 0;
            this.tamTinh = (int) Math.Ceiling(this.LCB* this.HSL);
            this.Luong = this.tamTinh + this.PC;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThongTinnhanvien nv1 = new ThongTinnhanvien("Luong Van Luong", "Nam", new DateTime (2023,02,12), 2.34f, 2500000, 4);
            Console.WriteLine("Thong tin nhan vien 1 : \n" +
                                    "Ho ten :; \t{0}\n" +
                                    "Gioi tinh: \t{1}\n" +
                                    "Ngay sinh: \t{2}\n" +
                                    "LCB: \t\t{3}\n" +
                                    "HSL: \t\t{4}\n" +
                                    "So nam: \t{5}\n" +
                                    "Phu cap: \t{6}\n" +
                                    "Tam tinh: \t{7}\n" +
                                    "Tien luong: \t{8}",
                                    nv1.hoTen, nv1.gioiTinh, nv1.ngaySinh.ToString(),
                                    nv1.LCB, nv1.HSL, nv1.soNam, nv1.PC, nv1.tamTinh, nv1.Luong);

            Console.WriteLine("-------------------------------------------");

            ThongTinnhanvien nv2 = new ThongTinnhanvien("Luong Van Luyen", "Nam", new DateTime(2023, 03, 12), 2.34f, 2500000, 6);
            Console.WriteLine("Thong tin nhan vien 1 : \n" +
                                    "Ho ten :; \t{0}\n" +
                                    "Gioi tinh: \t{1}\n" +
                                    "Ngay sinh: \t{2}\n" +
                                    "LCB: \t\t{3}\n" +
                                    "HSL: \t\t{4}\n" +
                                    "So nam: \t{5}\n" +
                                    "Phu cap: \t{6}\n" +
                                    "Tam tinh: \t{7}\n" +
                                    "Tien luong: \t{8}",
                                    nv2.hoTen, nv2.gioiTinh, nv2.ngaySinh.ToString(),
                                    nv2.LCB, nv2.HSL, nv2.soNam, nv2.PC, nv2.tamTinh, nv2.Luong);

            Console.ReadKey();
        }
    }
}
