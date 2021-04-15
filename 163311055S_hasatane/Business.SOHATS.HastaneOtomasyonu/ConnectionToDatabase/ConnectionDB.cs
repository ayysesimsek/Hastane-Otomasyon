using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.SOHATS.HastaneOtomasyonu
{
    public static class ConnectionDB
    {
        public static SqlConnection _connection = new SqlConnection("Server = DESKTOP-OB0RQNK\\MRSENGINEER; Database = SOHATS; Integrated Security = true; ");

        #region Veritabanına bağlantı ve sonlandırma işlemleri yapılıyor. 

        /// <summary>
        /// SOHATS veritabanına bağlantı saplanıyor. 
        /// </summary>
        public static void ConnectionToDatabase()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception error)
            {
                new Exception(error.Message);
            }
        }
        /// <summary>
        /// SOHATS veritabanına bağlantının sonlandırılması sağlanıyor.
        /// </summary>
        public static void EndConnectionToDatabase()
        {
            try
            {
                _connection.Close();
            }
            catch (Exception error)
            {
                new Exception(error.Message);
            }
        }

        #endregion
    }
}