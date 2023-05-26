using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Entities
{
    public class PhieuNhap
    {
        public int PhieuNhapId { get; set; }
        public string MaPhieu 
        {
            get
            {
                return $"MPN-{_ngaynhap}";
            }
            private set { }
        }
        public string TieuDe { get; set; }
        private DateTime _ngaynhap = DateTime.Now;
        public DateTime NgayNhap 
        {
            get
            {
                return _ngaynhap;
            }
            set
            {
                _ngaynhap = value;
            }
        }
        public IEnumerable<ChiTietPhieuNhap> chiTietPhieuNhapLists { get; set; }
        public void NhapThongTin()
        {
            Console.WriteLine("nhap tieu de:");
            TieuDe = Console.ReadLine();
        } 
    }
}
