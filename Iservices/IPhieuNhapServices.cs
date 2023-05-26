using EFC_03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Iservices
{
    public interface IPhieuNhapServices
    {
        void ThemPhieuNhap();
        void ThemChiTietPhieuNhap();
        PhieuNhap newPhieuNhap();
    }
}
