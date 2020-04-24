using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace CalcualtorLog
{
    public class LogDb : ILog
    {
        private string connectionstr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        public void WriteLog(string contents)
        {
            //连接打开
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionstr;
            con.Open();

            //语句
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Log (Id,Contents) VALUES(@id,@content)";
            cmd.Parameters.AddWithValue("@id", new Random().Next());
            cmd.Parameters.AddWithValue("@content", contents);

            //执行
            cmd.ExecuteNonQuery();

            //关闭
            con.Close();
        }

        public string Readlog()
        {
            string contents = string.Empty;

            //连接打开
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionstr;
            con.Open();

            //语句
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Log";

            //读取
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                contents += dataReader[1].ToString();
            }

            //关闭
            con.Close();

            return contents;
        }
    }
}