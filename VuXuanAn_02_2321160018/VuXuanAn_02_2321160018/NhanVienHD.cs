using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuXuanAn_02_2321160018
{
    class NhanVienHD:NhanVien
    {
        private int doanhthu;
        public NhanVienHD() : base()
        {
        }
        public NhanVienHD(string maso, string hoten, int Luongcung,int doanhthu) : base(maso, hoten, Luongcung)
        {
            this.doanhthu = doanhthu;
        }
        public int Doanhthu
        {
            set { doanhthu = value; }
            get { return doanhthu; }
        }
        public override int tinhLuong()
        {
            int luonghtuclanh = Luongcung + doanhthu;
            return luonghtuclanh;
        }
    }
}
