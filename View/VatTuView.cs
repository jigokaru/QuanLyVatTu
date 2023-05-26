using EFC_03.Entities;
using EFC_03.Iservices;
using EFC_03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.View
{
    public class VatTuView
    {
        IPhieuNhapServices phieuNhapServices = new PhieuNhapServices();
        IPhieuXuatServices phieuXuatServices = new PhieuXuatServices();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------Quan ly vat tu-----------");
            Console.WriteLine("1 Them phieu nhap");
            Console.WriteLine("2 Them phieu xuat");
            Console.WriteLine("3 Hien thi danh sach vat tu");
            Console.WriteLine("4 hien thi danh sach vat tu can nhap them");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            RequestController(c);
        }
        public void RequestController(char c)
        {
            List<VatTu> vatTus = new List<VatTu>();
            List<ChiTietPhieuNhap> chiTietPhieuNhaps = new List<ChiTietPhieuNhap>();
            List<ChiTietPhieuXuat> chiTietPhieuXuats = new List<ChiTietPhieuXuat>();
            List<PhieuNhap> phieuNhaps = new List<PhieuNhap>();
            List<PhieuXuat> phieuXuats = new List<PhieuXuat>();
            DanhSachVatTu danhSachVatTu = new DanhSachVatTu();
            switch (c)
            {
                case '1':
                    phieuNhapServices.ThemPhieuNhap();
                    Console.WriteLine("ban muon bao nhieu chi tiet phieu nhap:");
                    bool check = false;
                    int a;
                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out a);
                        if (!check || a <= 0)
                        {
                            Console.WriteLine("nhap lieu sai, yeu cau nhap lai");
                        }
                    } while (!check);
                    for(int i = 0; i < a; i++)
                    {
                        phieuNhapServices.ThemChiTietPhieuNhap();
                    }
                    break;
                case '2':
                    phieuXuatServices.ThemPhieuXuat();
                    Console.WriteLine("ban muon bao nhieu chi tiet phieu xuat:");
                    bool check1 = false;
                    int b;
                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out a);
                        if (!check || a <= 0)
                        {
                            Console.WriteLine("nhap lieu sai, yeu cau nhap lai");
                        }
                    } while (!check);
                    for (int i = 0; i < a; i++)
                    {
                        phieuXuatServices.ThemChiTietPhieuXuat();
                    }
                    break;
                case '3':
                    List<VatTu> vatTus1 = danhSachVatTu.danhSachVatTu();
                    foreach(VatTu vatTu in vatTus1)
                    {
                        Console.WriteLine($"{vatTu.TenVatTu}");
                        if(vatTu.SoLuongTon == 0)
                        {
                            Console.WriteLine("het hang");
                        }
                        else
                        {
                            Console.WriteLine($"SLTK: {vatTu.SoLuongTon}");
                        }
                    }
                    break;
                case '4':
                    List<VatTu> vatTu1 = danhSachVatTu.danhSachVatTu();
                    foreach(VatTu vatTu in vatTu1 )
                    {
                        if(vatTu.SoLuongTon == 0)
                        {
                            Console.WriteLine($"so vat tu can nhap them: {vatTu.TenVatTu}");
                        }
                    }
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
