using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
   public class NhanVienDAO :DBConnect
    {
        public DataTable LoadNhanVien()
        {
            string query = "Select MA_NV,TEN_NV,NS_NV,NGAYVAOLAM_NV,DIACHI_NV,GT_NV,DT_NV from NHANVIEN where XOA = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
            
        }

        public bool AddNhanVien(NhanVienDTO nvDto)
        {
            try
            {
                string strTruyVan1 = string.Format("insert into NHANVIEN(TEN_NV,DT_NV,NS_NV,NGAYVAOLAM_NV,DIACHI_NV,GT_NV,XOA) values(N'{0}','{1}','{2}','{3}',N'{4}',N'{5}',{6})",
                             nvDto.TEN_NV, nvDto.DT_NV, nvDto.NS_NV, nvDto.NGAYVAOLAM_NV, nvDto.DIACHI_NV, nvDto.GT_NV,nvDto.XOA);
                 SqlParameter[] sqlParameters = new SqlParameter[0];
                return executeInsertQuery(strTruyVan1, sqlParameters);
            }
            catch(Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
               
            }
            return true;

        }

        public bool UpdateNhanVien(NhanVienDTO nvDto)
        {
            try
            {
                string strTruyVan2 = string.Format("update NHANVIEN set TEN_NV = N'{0}',DT_NV = '{1}',NS_NV='{2}',NGAYVAOLAM_NV='{3}',DIACHI_NV=N'{4}',GT_NV='{5}' where Ma_NV = '{6}'"
                    , nvDto.TEN_NV, nvDto.DT_NV, nvDto.NS_NV, nvDto.NGAYVAOLAM_NV, nvDto.DIACHI_NV, nvDto.GT_NV,nvDto.MA_NV);

                SqlParameter[] sqlParameters = new SqlParameter[0];
                return executeInsertQuery(strTruyVan2, sqlParameters);
            }       
            
       
            catch(Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
               
            }
            return true;


        }
        public bool DeleteNhanVien(NhanVienDTO nvDto)
        {

            try
            {
                string strTruyVan2 = string.Format("update NHANVIEN set XOA = 1 where Ma_NV = '{0}'"
                    , nvDto.MA_NV);

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

       

    }
}
