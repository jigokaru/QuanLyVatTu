using EFC_03.Entities;
using EFC_03.Iservices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Services
{
    public class PhieuNhapServices : IPhieuNhapServices
    {
        private readonly AppDbContext _DbContext;
        public PhieuNhapServices()
        {
            _DbContext = new AppDbContext();
        }

        public void ThemPhieuNhap()
        {
            PhieuNhap phieuNhap = new PhieuNhap();
            phieuNhap.NhapThongTin();
            _DbContext.Add(phieuNhap);
            _DbContext.SaveChanges();
            
        }
        public void ThemChiTietPhieuNhap()
        {
            PhieuNhap phieuNhapnew = _DbContext.PhieuNhap.OrderBy(x => x.PhieuNhapId).Last();
            ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
            chiTietPhieuNhap.NhapThongTin();
            chiTietPhieuNhap.PhieuNhapId = phieuNhapnew.PhieuNhapId;
            VatTu check = _DbContext.VatTu.FirstOrDefault(x => x.VatTuId == chiTietPhieuNhap.VatTuId);
            if (check == null)
            {
                Console.WriteLine("Id vat tu khong ton tai, yeu cau nhap:");
                VatTu vatTu = new VatTu();
                vatTu.NhapThongTin();
                vatTu.SoLuongTon = chiTietPhieuNhap.SoLuongNhap;
                chiTietPhieuNhap.VatTu = vatTu;
            }
            else
            {
                
                check.SoLuongTon += chiTietPhieuNhap.SoLuongNhap;
                _DbContext.Update(check);
            }
            _DbContext.Add(chiTietPhieuNhap);
            _DbContext.SaveChanges();
            Console.WriteLine("thanh cong!");
        }
        public PhieuNhap newPhieuNhap()
        {
            return _DbContext.PhieuNhap.OrderBy(x => x.PhieuNhapId).Last();
        }

    }
}
