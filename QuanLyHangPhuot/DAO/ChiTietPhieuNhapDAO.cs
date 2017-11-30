using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ChiTietPhieuNhapDAO:DBConnect
    {
        public DataTable LoadChiTietPhieuNhap()
        {
            string query = "select * from CTPHIEUNHAP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable GetChiTietPhieuNhap(string txt_MaPN)
        {
            string sQuery = "Select * from CTPHIEUNHAP WHERE MA_PN='" + txt_MaPN + "' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(sQuery, sqlParameters);
        }
    }
}
