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
    public class NhaSanXuatBUS
    {
        NhaSanXuatDAO nsxDao = new NhaSanXuatDAO();

        public DataTable loadNhaSanXuat()
        {
            DataTable dataTable = new DataTable();
            dataTable = nsxDao.LoadNhaSanXuat();
            return dataTable;
        }

        public bool addNhaSanXuat(NhaSanXuatDTO nsxDto)
        {
            return nsxDao.AddNhaSanXuat(nsxDto);
        }
        public bool updateNhaSanXuat(NhaSanXuatDTO nsxDto)
        {
            return nsxDao.UpdateNhaSanXuat(nsxDto);
        }
        public bool deleteNhaSanXuat(NhaSanXuatDTO nsxDto)
        {
            return nsxDao.DeleteNhaSanXuat(nsxDto);
        }
        public DataTable searchNhaSanXuat(string txtTimKiem)
        {
            return nsxDao.SearchNhaSanXuat(txtTimKiem);
        }
    }
}
