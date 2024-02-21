using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuXuanAn_02_2321160018
{
    class NhanVien
    {
        private string maso;
        private string hoten;
        private int luongcung;
        public NhanVien()
        {
        }
        public NhanVien(string maso, string hoten, int luongCung)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongcung = luongcung;
        }
            public string MaSo
        {
            set { this.maso = value; }
            get { return this.maso; }
        }
        public string HoTen
        {
            set { this.hoten = value; }
            get { return this.hoten; }
        }
        public int Luongcung
        {
            set { this.luongcung = value; }
            get { return this.luongcung; }
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap thong tin nhan vien ");
            Console.Write("Nhap ma so:");
            this.maso = Console.ReadLine();
            Console.Write("Nhap ho ten:");
            this.hoten = Console.ReadLine();
            Console.Write("Nhap so luong :");
            this.luongcung = int.Parse(Console.ReadLine());
        }
        public virtual int tinhLuong()
        {
            return 0;
        }
    }
}
    

