using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Database
{
    public static class DbHelper
    {
        static  string db_address = "Data Source=ADMIN-PC;Initial Catalog=ThucTap;User ID=sa;Password=Thienbk0305@;";

        public static List<SinhVien> Sinhvien_GetList()
        {
            var list = new List<SinhVien>();
            try
            {
                //Bước 1: Truy cập vào kho (database)
                // mở connect đển địa chỉ của sqlserver 
                var sqlconn = new SqlConnection(db_address);
                // kiểm tra trạng thái kết nối xem đang là đóng hay mở 
                if (sqlconn.State == System.Data.ConnectionState.Closed)
                {
                    sqlconn.Open();
                }

                //Bước 2 :Lấy hàng 
                // SqlCommand để thực hiện thao tác với dữ liệu
                var cmd = new SqlCommand("SP_SinhVien_GetList", sqlconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //var cmd1 = new SqlCommand("SELECT * FROM tblProduct", sqlconn);
                //cmd1.CommandType = System.Data.CommandType.Text;

                // Bước 3: Quay về
                var reader = cmd.ExecuteReader(); // trả về dữ lieuj ở dang bảng

                //Chất hàng lên xe 
                while (reader.Read())
                {
                    var sinhvien = new SinhVien();

                    int masv = reader["masv"] != null ? Convert.ToInt32(reader["masv"].ToString()) : 0;
                    string hotensv = reader["hotensv"] != null ? reader["hotensv"].ToString() : "";
                    string makhoa = reader["makhoa"] != null ? reader["makhoa"].ToString() : "";
                    int namsinh = reader["namsinh"] != null ? Convert.ToInt32(reader["namsinh"].ToString()) : 0;
                    string quequan = reader["quequan"] != null ? reader["quequan"].ToString() : "";

                    sinhvien.masv = masv;
                    sinhvien.hotensv = hotensv;
                    sinhvien.makhoa = makhoa;
                    sinhvien.quequan = quequan;
                    list.Add(sinhvien);
                }

                //Quay về 
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
