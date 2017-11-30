using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class SanPhamBUS
    {
         SanPhamDAO spDao = new SanPhamDAO();
        
        public DataTable loadSanPham()
        {
            DataTable dataTable = new DataTable();
            dataTable = spDao.LoadSanPham();
            return dataTable;
        }

        public bool addSanPham(SanPhamDTO spDto)
        {
            return spDao.AddSanPham(spDto);
        }

        public bool updateSanPham(SanPhamDTO spDto)
        {
            return spDao.UpdateSanPham(spDto);
        }

        public bool deleteSanPham(SanPhamDTO spDto)
        {
            return spDao.DeleteNhanVien(spDto);
        }

        public DataTable searchSanPham(string txtTimKiem)
        {
            return spDao.SearchSanPham(txtTimKiem);
        }

        public SanPhamDTO getTenSanPham(string txt_MaSanPham)
        {
            try
            {
                DataTable dt = spDao.GetTenSanPham(txt_MaSanPham);
                SanPhamDTO sp = new SanPhamDTO();
                sp.TEN_SP = dt.Rows[0]["TEN_SP"].ToString();
                sp.GIA_SP = float.Parse(dt.Rows[0]["GIA_SP"].ToString());
                return sp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
