using EFC_03.Entities;
using EFC_03.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Services
{
    public class PhieuXuatServices : IPhieuXuatServices
    {
        private readonly AppDbContext _DbContext;
        public PhieuXuatServices()
        {
            _DbContext = new AppDbContext();
        }

        public void ThemPhieuXuat()
        {
            PhieuXuat phieuXuat = new PhieuXuat();
            phieuXuat.NhapThongTin();
            _DbContext.Add(phieuXuat);
            _DbContext.SaveChanges();
        }

        public void ThemChiTietPhieuXuat()
        {
            PhieuXuat phieuXuatnew = _DbContext.PhieuXuat.OrderBy(x => x.PhieuXuatId).Last();
            ChiTietPhieuXuat chiTietPhieuXuat = new ChiTietPhieuXuat();
            chiTietPhieuXuat.NhapThongTin();
            
            VatTu vatTu = _DbContext.VatTu.FirstOrDefault(x => x.VatTuId == chiTietPhieuXuat.VatTuId);
            do
            {
                if(vatTu == null)
                {
                    Console.WriteLine("Id vat tu khong ton tai, yeu cau nhap lai:");
                    chiTietPhieuXuat.NhapThongTin();
                }
                vatTu = _DbContext.VatTu.FirstOrDefault(x => x.VatTuId == chiTietPhieuXuat.VatTuId);
            } while(vatTu == null);
            
            
            if((vatTu.SoLuongTon - chiTietPhieuXuat.SoLuongXuat) >= 0)
            {
                vatTu.SoLuongTon -= chiTietPhieuXuat.SoLuongXuat;
                _DbContext.Update(vatTu);
            }
            else
            {
                Console.WriteLine("so luong xuat khong duoc vuot qua so luong ton kho");
            }
            chiTietPhieuXuat.PhieuXuatId = phieuXuatnew.PhieuXuatId;
            _DbContext.Add(chiTietPhieuXuat);
            _DbContext.SaveChanges();
            Console.WriteLine("thanh cong!");
        }
        public PhieuXuat newPhieuXuat()
        {
            return _DbContext.PhieuXuat.OrderBy(x => x.PhieuXuatId).Last();
        }
    }
}
