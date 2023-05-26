using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Entities
{
    public class ChiTietPhieuNhap
    {
        public int ChiTietPhieuNhapID { get; set; }
        public int VatTuId { get; set; }
        public VatTu VatTu { get; set; }
        public int PhieuNhapId { get; set; }
        public PhieuNhap phieuNhap { get; set; }
        public int SoLuongNhap { get; set; }
        public void NhapThongTin()
        {
            Console.WriteLine("nhap vat tu ID:");
            VatTuId = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so luong nhap:");
            SoLuongNhap = int.Parse(Console.ReadLine());
        }
    }
}
