using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuXuanAn_02_2321160018
{
    class QLNV:NhanVien
    {
        private List<NhanVien> dsNV;
        public QLNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("Chon loai Nhan Vien [1:Hoang Ha, 2:Van Thang]:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap(); 
                        dsNV.Add(nv); 
                        break;
                    case 2:
                        nv = new NhanVienBC(); 
                        nv.Nhap(); 
                        dsNV.Add(nv); 
                        break;
                    default:
                        Console.WriteLine("Ban chon sai. Vui long chon 1 hoac 2.");
                        break;
                }

                Console.Write("Ban co muon tiep tuc khong? Y/N:");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-10}  {"Ho Ten",20}  {"so luong ",10}  {"Luong",20}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.MaSo,-10}  {x.HoTen,20}  {x.Luongcung,10}  {x.tinhLuong(),20:#,##0 vnd}");
            }
        }
        public double TinhTongLuong()
        {
            int tongluong = 0;
            foreach(var nv in dsNV)
            {
                tongluong = nv.tinhLuong();

            }
            return tongluong;
            
            
        }
        public double TinhLuongTrungBinh()
        {
            return (double)TinhTongLuong() / dsNV.Count;
        }
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            QLNV ql = new QLNV();
            int chon = 0;
            do
            {
                //in thuc don ra man hinh
                Console.WriteLine("***CHUONG TRINH QUAN LY NHAN VIEN***");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1.Nhap danh sach nhan vien.");
                Console.WriteLine("2.Xuat thong tin nhan vien.");
                Console.WriteLine("3.Thong ke tong luong nhan vien .");
                Console.WriteLine("4.Thong ke  luong trung binh nhan vien .");
                Console.WriteLine("0.Thoat chuong trinh.");
                Console.WriteLine("--------------------------------");
                Console.Write("Ban chon chuc nang:");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        ql.NhapDS();
                        break;

                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                      
                        Console.WriteLine($"Tong tien luong phai tra: {ql.TinhTongLuong():#,##0 vnd}");
                        break;
                    case 4:
                        Console.WriteLine($"Tong tien luong phai tra: {ql.TinhLuongTrungBinh():#,##0 vnd}");
                        break;
                    case 0:
                        Console.WriteLine("GoodBye.");
                        Console.ReadLine();
                        break;
                }

            } while (chon != 0);
        }
    }
}
