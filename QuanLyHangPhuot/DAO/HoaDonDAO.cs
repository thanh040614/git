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
    public class HoaDonDAO:DBConnect
    {
        public DataTable LoadHoaDon()
        {
            string query = "select * from HOADON";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        
        public DataTable SearchHoaDon(string txtTimKiem)// ?????
        {
            string sQuery = "Select *from HOADON where MA_HD like N'%" + txtTimKiem + "%' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(sQuery, sqlParameters);
        }

        public int GetMaHoaDonLast()
        {

            string sQuery = "select count(MaHD) FROM HOADON";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExScarlar(sQuery, sqlParameters);

        }

        public string getMaHoaDonMoi()
        {
            string value = "";
            string query = "SELECT TOP 1 MA_HD  FROM HOADON ORDER BY MA_HD DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable temp = executeSelectQuery(query, sqlParameters);
            value = temp.Rows[0][0].ToString();

            return value;
        }

        public bool AddHoaDon(HoaDonDTO hoaDon)
        {
           // hoaDon.MA_NV = "NV002";
            string sQuery = string.Format("INSERT INTO HOADON(MA_KH,MA_NV,NGAYLAP_HD) VALUES('{0}','{1}',GETDATE())", hoaDon.MA_KH, hoaDon.MA_NV);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeInsertQuery(sQuery, sqlParameters);
        }
    }
}
