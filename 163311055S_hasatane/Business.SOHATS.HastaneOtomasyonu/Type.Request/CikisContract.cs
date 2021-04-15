using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.HastaneOtomasyonu.Entitiy;

namespace Business.SOHATS.HastaneOtomasyonu
{
    public class CikisContract
    {
        #region InsertExitDischarged Method 
        public bool InsertExitDischarged(cikis exit)
        {
            if (exit == null)
                return false;
            else
            {
                SqlCommand command = ConnectionDB._connection.CreateCommand();
                command.CommandText = "Execute [dbo].[_insExitDischarged] " +
                                      "@FileNumber, @ShipmentDate, @OutputClock, " +
                                      "@Pay, @TotalAmount";

                command.Parameters.Add("@FileNumber", SqlDbType.VarChar, 10).Value = exit.FileNumber;
                command.Parameters.Add("@ShipmentDate", SqlDbType.VarChar, 10).Value = exit.ShipmentDate;
                command.Parameters.Add("@OutputClock", SqlDbType.DateTime).Value = (DateTime)exit.OutputClock;
                command.Parameters.Add("@Pay", SqlDbType.VarChar, 20).Value = exit.Pay;
                command.Parameters.Add("@TotalAmount", SqlDbType.VarChar, 20).Value = exit.TotalAmount;

                ConnectionDB.ConnectionToDatabase();
                command.ExecuteNonQuery();
                ConnectionDB.EndConnectionToDatabase();

                return true;
            }
        }
        #endregion

        #region GetPatient --> hasta tablosundaki bilgilerin getirilmesi sağlanıyor...
        public List<cikis> GetPatient(string fileNumber)
        {
            ConnectionDB.ConnectionToDatabase();
            SqlCommand command;
            SqlDataAdapter adapter;
            SqlDataReader reader;
            SqlParameter parameter;

            #region Stored Prosedure bağlantısı 
            if (fileNumber == null)
                command = new SqlCommand("[dbo].[_selGetPatient]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[_selGetOutputDischargedPrimaryKey]", ConnectionDB._connection);
                command.CommandType = CommandType.StoredProcedure;
                parameter = new SqlParameter("@FileNumber", fileNumber);
                parameter.Direction = ParameterDirection.Input;
                parameter.DbType = DbType.String;
                command.Parameters.Add(parameter);
            }
            #endregion

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            command.ExecuteNonQuery();

            #region Fill all to Data
            reader = command.ExecuteReader();
            List<cikis> patients = new List<cikis>();
            while (reader.Read())
            {
                cikis patient = new cikis();
                patient.FileNumber= reader["FileNumber"].ToString();
                patient.ShipmentDate = reader["ShipmentDate"].ToString();
                patient.OutputClock = (DateTime)reader["OutputClock"];
                patient.Pay = reader["Pay"].ToString();
                patient.TotalAmount = reader["TotalAmount"].ToString();
                patients.Add(patient);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return patients;
        }
        #endregion
    }
}

