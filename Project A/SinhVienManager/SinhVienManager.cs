using Project_A.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.SinhVienManager
{
    public class SinhVienManager : ISinhVien
    {
        public int ProductInsert(SinhVienDataBase sinhvien)
        {
            try
            {
                // Bước 1: mở connection đến Database
                var sqlconn = DbHelper.GetSqlConnection();

                //Bước 2:SqlCommand để thực hiện thao tác với dữ liệu
                var cmd = new SqlCommand("SP_SinhVienInsertUpdate", sqlconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_masv", sinhvien.masv);
                cmd.Parameters.AddWithValue("@_hotensv", sinhvien.hotensv);
                cmd.Parameters.AddWithValue("@_makhoa", sinhvien.makhoa);
                cmd.Parameters.AddWithValue("@_namsinh", sinhvien.namsinh);
                cmd.Parameters.AddWithValue("@_quequan", sinhvien.quequan);
                cmd.Parameters.Add("@_ResponseCode", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;

                // Bước 3: thực hiện insert
                cmd.ExecuteNonQuery();
                //sqlconn.Close();
                var result = cmd.Parameters["@_ResponseCode"].Value != null ? Convert.ToInt32(cmd.Parameters["@_ResponseCode"].Value) : 0;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<SinhVienDataBase> SinhvienGetList(int masv)
        {

            var list = new List<SinhVienDataBase>();
            try
            {
                //Bước 1: Truy cập vào kho (database)
                // mở connect đển địa chỉ của sqlserver 
                var sqlconn = DbHelper.GetSqlConnection();

                //Bước 2 :Lấy hàng 
                // SqlCommand để thực hiện thao tác với dữ liệu
                var cmd = new SqlCommand("SP_SinhVien_GetList", sqlconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //var cmd1 = new SqlCommand("SELECT * FROM tblProduct", sqlconn);
                //cmd1.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@_masv", masv);

                // Bước 3: Quay về
                var reader = cmd.ExecuteReader(); // trả về dữ lieuj ở dang bảng

                //Chất hàng lên xe 
                while (reader.Read())
                {
                    var sinhvien = new SinhVienDataBase();

                    masv = reader["masv"] != null ? Convert.ToInt32(reader["masv"].ToString()) : 0;
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
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
