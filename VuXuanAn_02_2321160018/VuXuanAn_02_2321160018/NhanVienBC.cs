using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuXuanAn_02_2321160018
{
    class NhanVienBC:NhanVien
    {
        private string Mucxeploai;
        public NhanVienBC() : base()
        {
        }
        public NhanVienBC(string maso, string hoten, int Luongcung,string mucxeploai) : base(maso, hoten,Luongcung)
        {
            this.Luongcung = Luongcung;
        }

        public string MucXepLoai { get; set; }
        public override void Nhap()
        {
            base.Nhap(); 
            Console.Write("Nhap muc xep loai (A, B, C): ");
            Mucxeploai=Console.ReadLine();

        }
        public override int tinhLuong()
        {
           switch(Mucxeploai)
            {
                case "A":
                    return (int)(1.5 * Luongcung);
                case "B":
                    return (int)(1.0 * Luongcung);
                case "C":
                    return (int)(0.5 * Luongcung);
                default:
                    return 0;
                    
            }    
        }

    }
}
