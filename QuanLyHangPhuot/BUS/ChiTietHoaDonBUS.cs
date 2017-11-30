using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO cthdDao = new ChiTietHoaDonDAO();
        public DataTable loadChiTietHoaDon(string txt_MaHD)
        {
            return cthdDao.LoadChiTietHoaDon(txt_MaHD);
        }
        public bool addCTHD(ChiTietHoaDonDTO ctHoaDon)
        {
            return cthdDao.AddCTHD(ctHoaDon);
        }

    }
}
