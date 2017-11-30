using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVienBUS
    {
         NhanVienDAO  nvDao = new NhanVienDAO();

        public DataTable loadNhanVien()
        {
            DataTable dataTable = new DataTable();
            dataTable = nvDao.LoadNhanVien();
            return dataTable;
        }
        public bool addNhanVien(NhanVienDTO nvDto)
        {
            return nvDao.AddNhanVien(nvDto);
        }
        public bool updateNhanVien(NhanVienDTO nvDto)
        {
            return nvDao.UpdateNhanVien(nvDto);
        }
        public bool deleteNhanVien(NhanVienDTO nvDto)
        {
            return nvDao.DeleteNhanVien(nvDto);
        }
    }
}
