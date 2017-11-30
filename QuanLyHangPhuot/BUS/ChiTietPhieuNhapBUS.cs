using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAO ctpnDao = new ChiTietPhieuNhapDAO();
        public DataTable loadChiTietPhieuNhap()
        {
            DataTable datatable = new DataTable();
            datatable = ctpnDao.LoadChiTietPhieuNhap();
            return datatable;
        }

        public DataTable getChiTietPhieuNhap(string txt_MaPN)
        {
            return ctpnDao.GetChiTietPhieuNhap(txt_MaPN);
        }
    }
}
