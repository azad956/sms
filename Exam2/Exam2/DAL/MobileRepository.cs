using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam2.Models;

namespace Exam2.DAL
{
    public class MobileRepository
    {
        //2 Create Connection String to Connect DB
        static string conString = @"Server=.\SQLEXPRESS; Database=MobileDb; Integrated Security=true";
        
        //3 Build Connection using Connection String
        SqlConnection con = new SqlConnection(conString);
        public bool Save(MobileCls mobile)
        {
            //4
            string query = @"INSERT INTO mobileTAble (ModelName, IME, Price) VALUES ('"+mobile.ModelName+"', '"+mobile.IME+"', "+mobile.Price+") ";
            //5
            SqlCommand sqlCommand = new SqlCommand(query, con);

            //6
            con.Open();

            //7
            int rowCount = sqlCommand.ExecuteNonQuery();

            //8
            con.Close();

            //9
            if (rowCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Exists(MobileCls mobile)
        {
            string query = @"SELECT * FROM mobileTAble WHERE IME = '"+mobile.IME+"'";
            //5
            SqlCommand sqlCommand = new SqlCommand(query, con);

            //6
            con.Open();

            //7
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            string data = "";

            if (sqlDataReader.Read())
            {
                data = sqlDataReader["Id"].ToString();
            }


            //8
            con.Close();

            //9
            if (!String.IsNullOrEmpty(data))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Search(MobileCls mobile)
        {
            string query = @"SELECT * FROM mobileTAble WHERE IME = '" + mobile.IME + "'";
            //5
            SqlCommand sqlCommand = new SqlCommand(query, con);

            //6
            con.Open();

            //7
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            string data = "";

            if (sqlDataReader.Read())
            {
                data = sqlDataReader["Id"].ToString();
                mobile.ModelName = sqlDataReader["ModelName"].ToString();
                mobile.IME = sqlDataReader["IME"].ToString();
                mobile.Price = Convert.ToDouble(sqlDataReader["Price"].ToString());
            }


            //8
            con.Close();

            //9
            if (!String.IsNullOrEmpty(data))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
        public List<MobileCls> Search(double lowPrice, double highPrice)
        {
            string query = @"SELECT * FROM mobileTAble WHERE price BETWEEN " + lowPrice + " AND  " + highPrice + "";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);

            con.Close();
            //
            List<MobileCls> mobiles = new List<MobileCls>();

            int sl = 1;
            foreach (DataRow dataRow in dt.Rows)
            {
                
                MobileCls mobile = new MobileCls();
                mobile.Id = sl;

                mobile.ModelName = dataRow["ModelName"].ToString();
                mobile.IME = dataRow["IME"].ToString();
                mobile.Price = Convert.ToDouble(dataRow["Price"].ToString());

                mobiles.Add(mobile);
                sl++;
            }

            return mobiles;
        }
    }
}
