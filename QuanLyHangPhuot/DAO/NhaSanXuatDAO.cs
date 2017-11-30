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
    public class NhaSanXuatDAO:DBConnect
    {
        public DataTable LoadNhaSanXuat()
        {
            string query = "Select MA_NSX,TEN_NSX,DT_NSX,DIACHI_NSX from NHAsANXUAT where XOA = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);

        }
        public bool AddNhaSanXuat(NhaSanXuatDTO nsxDto)
        {
            try
            {
                string strTruyVan1 = string.Format("insert into NHASANXUAT(TEN_NSX,DT_NSX,DIACHI_NSX,XOA) values(N'{0}','{1}',N'{2}',{3})",
                                nsxDto.TEN_NSX, nsxDto.DT_NSX, nsxDto.DIACHI_NSX,nsxDto.XOA);
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

        public bool UpdateNhaSanXuat(NhaSanXuatDTO nsxDto)
        {
            try
            {
                string strTruyVan2 = string.Format("update NHASANXUAT set TEN_NSX = N'{0}',DT_NSX = '{1}',DIACHI_NSX=N'{2}' where Ma_NSX = '{3}'"
                    , nsxDto.TEN_NSX, nsxDto.DT_NSX, nsxDto.DIACHI_NSX, nsxDto.MA_NSX);

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
        public bool DeleteNhaSanXuat(NhaSanXuatDTO nsxDto)
        {
            try
            {
                string strTruyVan2 = string.Format("update NHASANXUAT set XOA = 1 where Ma_NSX = '{0}'"
                    , nsxDto.MA_NSX);

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
        public DataTable SearchNhaSanXuat(string txtTimKiem)
        {
              
            string strTruyVan3 = "Select *from NHASANXUAT where MA_NSX like N'%" + txtTimKiem + "%' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(strTruyVan3, sqlParameters);
        }


    }
}
