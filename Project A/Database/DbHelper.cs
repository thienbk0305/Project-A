﻿using System;
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

        public static SqlConnection GetSqlConnection()
        {
            try
            {
                var sqlconn = new SqlConnection(db_address);
                // kiểm tra trạng thái kết nối xem đang là đóng hay mở 
                if (sqlconn.State == System.Data.ConnectionState.Closed)
                {
                    sqlconn.Open();
                }

                return sqlconn;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
