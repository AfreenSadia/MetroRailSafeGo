using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrorRailSafeGo
{
    internal class DataConnect
    {
        SqlConnection sc = null;

        public static string ConnReturn()
        {
            return @"Data Source=SADIA-PC\SQLEXPRESS;Initial Catalog=MetroRailSafeGo;Integrated Security=True";
        }
        
        public DataConnect()
        {
            sc = new SqlConnection(ConnReturn());
        }


        /// <summary>
        /// Add in database. Login Only
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>

        public DataTable Add(string sql)
        {
            string querry = sql;
            SqlDataAdapter sda = new SqlDataAdapter(querry, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Data Show Purpose only
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable DataRetrivation(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sc);
            sc.Open();
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            sc.Close();
            return table;
        }

        /// <summary>
        /// No Place to Show, Just Add or Update or Delete from Database
        /// </summary>
        /// <param name="sql"></param>
        public bool Add_Update_Delete(string sql)
        {
            bool decision = false;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                decision = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                decision = false;
            }
            finally
            {
                sc.Close();
            }
            return decision;
        }




    }
}
