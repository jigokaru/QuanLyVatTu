using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Entities
{
    public class ChiTietPhieuXuat
    {
        public int ChiTietPhieuXuatID { get; set; }
        public int VatTuId { get; set; }
        public VatTu VatTu { get; set; }
        public int PhieuXuatId { get; set; }
        public PhieuXuat phieuXuat { get; set; }
        public int SoLuongXuat { get; set; }
        public void NhapThongTin()
        {
            Console.WriteLine("nhap vat tu ID:");
            VatTuId = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so luong Xuat:");
            SoLuongXuat = int.Parse(Console.ReadLine());
        }
    }
}
