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
   public class SanPhamDAO:DBConnect
    {
        public DataTable LoadSanPham()
        {
            string query = "Select MA_SP,TEN_SP,NGUYENLIEU_SP,MA_NSX, GIA_SP from SANPHAM where XOA = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);

        }
        public bool AddSanPham(SanPhamDTO spDto)
        {
            try
            {
                string strTruyVan1 = string.Format("insert into SANPHAM(TEN_SP,NGUYENLIEU_SP,MA_NSX, GIA_SP,XOA) values(N'{0}',N'{1}','{2}',{3},{4})",
                              spDto.TEN_SP, spDto.NGUYENLIEU_SP, spDto.MA_NSX, spDto.GIA_SP,spDto.XOA);
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

        public bool UpdateSanPham(SanPhamDTO spDto)
        {
            try
            {
                string strTruyVan2 = string.Format("update SANPHAM set TEN_SP = N'{0}',NGUYENLIEU_SP = N'{1}',MA_NSX='{2}',GIA_SP={3} where Ma_SP = '{4}'"
                    , spDto.TEN_SP, spDto.NGUYENLIEU_SP, spDto.MA_NSX, spDto.GIA_SP, spDto.MA_SP);

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

        public bool DeleteNhanVien(SanPhamDTO spDto)
        {

            try
            {
                string strTruyVan2 = string.Format("update SANPHAM set XOA = 1 where Ma_SP = '{0}'"
                    , spDto.MA_SP);

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

        public DataTable SearchSanPham(string txtTimKiem)
        {

            string strTruyVan3 = "Select *from SANPHAM where MA_SP like N'%" + txtTimKiem + "%' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(strTruyVan3, sqlParameters);
        }

        public DataTable GetTenSanPham(string txt_MaSanPham)
        {
            string sQuery = "Select  TEN_SP,GIA_SP from SANPHAM where MA_SP ='" + txt_MaSanPham + "' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(sQuery, sqlParameters);
        }
    }
}
