using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Entities
{
    public class PhieuXuat
    {
        public int PhieuXuatId { get; set; }
        public string MaPhieu
        {
            get
            {
                return $"MPX-{_ngayxuat}";
            }
            private set { }
        }
        public string TieuDe { get; set; }
        private DateTime _ngayxuat = DateTime.Now;
        public DateTime NgayXuat 
        {
            get
            {
                return _ngayxuat;
            }
            set
            {
                _ngayxuat = value;
            }
        }
        public IEnumerable<ChiTietPhieuXuat> chiTietPhieuXuatLists { get; set; }
        public void NhapThongTin()
        {
            Console.WriteLine("nhap tieu de:");
            TieuDe = Console.ReadLine();
        }
    }
}
