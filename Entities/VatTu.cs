using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Entities
{
    public class VatTu
    {
        public int VatTuId { get; set; }
        public string TenVatTu { get; set; }
        public int SoLuongTon { get; set; }
        public IEnumerable<ChiTietPhieuNhap> chiTietPhieuNhapLists { get; set; }
        public IEnumerable<ChiTietPhieuXuat> chiTietPhieuXuatLists { get; set; }
        public void NhapThongTin()
        {
            Console.WriteLine("nhap ten vat tu:");
            TenVatTu = Console.ReadLine();
            
        }
    }
}
