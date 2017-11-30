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
   public class HoaDonBUS
    {
        HoaDonDAO hdDao = new HoaDonDAO();

        public DataTable loadHoaDon()
        {
            DataTable dataTable = new DataTable();
            dataTable = hdDao.LoadHoaDon();
            return dataTable;
        }

        public DataTable searchHoaDon(string txtTimKiem)
        {
            return hdDao.SearchHoaDon(txtTimKiem);
        }

        public int getMaHoaDonLast()
        {
            return hdDao.GetMaHoaDonLast();
        }
        public bool addHoaDon(HoaDonDTO hoaDon)
        {
            return hdDao.AddHoaDon(hoaDon);
        }

        public string getHoaDonMoi()
        {
            return hdDao.getMaHoaDonMoi();
        }
    }
}
