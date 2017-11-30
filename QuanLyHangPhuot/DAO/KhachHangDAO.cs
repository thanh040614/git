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
    public class KhachHangDAO:DBConnect
    {
        public DataTable LoadKhachHang()
        {
            string query = "Select MA_KH,TEN_KH,DT_KH,DIACHI_KH from KHACHHANG where XOA = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }

        public string getLastMaKH()
        {
            string value = "";
            string query = "SELECT TOP 1 MA_KH FROM KHACHHANG ORDER BY MA_KH DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable temp = executeSelectQuery(query, sqlParameters);
            value = temp.Rows[0][0].ToString();

            return value;
        }
        public bool AddKhachHang(KhachHangDTO khDto)
        {
            try
            {
                string strTruyVan1 =string.Format( "insert into KHACHHANG(TEN_KH,DT_KH,DIACHI_KH,XOA) values(N'{0}','{1}',N'{2}',{3})", khDto.TEN_KH, khDto.DT_KH, khDto.DIACHI_KH, khDto.XOA);
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
        public bool UpdateKhachHang(KhachHangDTO khDto)
        {
            try
            {
                string strTruyVan1 = string.Format("update KHACHHANG set TEN_KH = N'{0}',DT_KH= '{1}',DIACHI_KH=N'{2}' where Ma_KH = '{3}'"
                    , khDto.TEN_KH, khDto.DT_KH, khDto.DIACHI_KH, khDto.MA_KH);
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
        public bool DeleteKhachHang(KhachHangDTO khDto)
        {
            try
            {
                string strTruyVan2 = string.Format("update KHACHHANG set XOA = 1 where Ma_KH = '{0}'"
                    , khDto.MA_KH);

                SqlParameter[] sqlParameters = new SqlParameter[0];
                return executeInsertQuery(strTruyVan2, sqlParameters);
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
        public DataTable SearchKhachHang(string txtTimKiem)
        {

            string strTruyVan3 = "Select *from KHACHHANG where MA_KH like N'%" + txtTimKiem + "%' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(strTruyVan3, sqlParameters);
        }

    }
}
