using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace BUS
{
    public class PhieuNhapBUS
    {
        PhieuNhapDAO pnDao = new PhieuNhapDAO();
        public DataTable loadPhieuNhap()
        {
            DataTable datatable = new DataTable();
            datatable = pnDao.LoadPhieuNhap();
            return datatable;

        }
        //tim Mã PN
        public DataTable searchMaPhieuNhap(string txtTimKiem)
        {
            return pnDao.SearchMaPhieuNhap(txtTimKiem);
        }
    }
}
