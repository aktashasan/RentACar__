using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace RentACar__
{
    class db
    {
        public static String ConnStr = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
        public MySqlConnection baglanti = new MySqlConnection(ConnStr);
        public string baglantıCont()
        {
            try
            {
                baglanti.Open();
                return "true";
            }
            catch(MySqlException ex)
            {
                return ex.Message;
            }
        }
   
    }
}
