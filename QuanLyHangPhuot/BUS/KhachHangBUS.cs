using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khDao = new KhachHangDAO();

        public DataTable loadKhachHang()
        {
            DataTable dataTable = new DataTable();
            dataTable = khDao.LoadKhachHang();
            return dataTable;
        }
        public bool addKhachHang(KhachHangDTO khDto)
        {
            return khDao.AddKhachHang(khDto);
        }
        public string getNewMAKhachHang()
        {
            return khDao.getLastMaKH();
        }
        public bool updateKhachHang(KhachHangDTO khDto)
        {
            return khDao.UpdateKhachHang(khDto);
        }
        public bool deleteKhachHang(KhachHangDTO khDto)
        {
            return khDao.DeleteKhachHang(khDto);
        }
        public DataTable searchKhachHang(string txtTimKiem)
        {
            return khDao.SearchKhachHang(txtTimKiem);
        }
    }
}
