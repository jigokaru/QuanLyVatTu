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
    public class DanhSachVatTu : IDanhSachVatTu
    {
        private readonly AppDbContext _DbContext;

        public DanhSachVatTu()
        {
            _DbContext = new AppDbContext();
        }
        public List<VatTu> danhSachVatTu()
        {
            return _DbContext.VatTu.ToList();
        }


    }
}
