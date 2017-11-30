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
    public class PhieuNhapDAO:DBConnect
    {
        public DataTable LoadPhieuNhap()
        {
            string query = "select * from PHIEUNHAP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }

        public bool AddPhieuNhap(PhieuNhapDTO pnDto)
        {
            try
            {
                string strTruyVan1 = string.Format("insert into PHIEUNHAP(NGAYNHAP,MA_NV) values('{0}','{1}')",
                             pnDto.NGAYNHAP, pnDto.MA_NV);
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return executeInsertQuery(strTruyVan1, sqlParameters);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();

            }
            return true;
        }
        public DataTable SearchMaPhieuNhap(string txtTimKiem)
        {
            string sQuery = "Select *from PHIEUNHAP where MA_PN like N'%" + txtTimKiem + "%' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(sQuery, sqlParameters);
        }
    }
}
