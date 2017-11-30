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
    public class ChiTietHoaDonDAO:DBConnect
    {
        public DataTable LoadChiTietHoaDon(string txt_MaHD)
        {
            string sQuery = "Select * from CTHOADON WHERE MA_HD='" + txt_MaHD + "' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(sQuery, sqlParameters);
        }
        public bool AddCTHD(ChiTietHoaDonDTO ctHoaDon)
        {
            string sQuery = string.Format("INSERT INTO CTHOADON(MA_HD,MA_SP,SL,DVT,DONGIA,THANHTIEN) VALUES('{0}','{1}',{2},'{3}',{4},'{5}')"
                , ctHoaDon.MA_HD,ctHoaDon.MA_SP, ctHoaDon.SL, ctHoaDon.DVT, ctHoaDon.DONGIA, ctHoaDon.SL*ctHoaDon.DONGIA);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeInsertQuery(sQuery, sqlParameters);
        }
    }
}
