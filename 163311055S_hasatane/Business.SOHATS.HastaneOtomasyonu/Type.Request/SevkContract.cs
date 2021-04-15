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
    public class SevkContract
    {
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public SqlParameter parameter;

        #region Discharged --> sevk tablosuna veri kaydı yapılmaktadır.
        public bool Discharged(sevk sevk)
        {
            if (sevk == null)
            {
                return false;
            }
            else
            {
                SqlCommand command = ConnectionDB._connection.CreateCommand();
                command.CommandText = "Execute [dbo].[_insSevk] " +
                                      "@ShipmentDate, @FileNumber," +
                                      "@Polyclinic, @Clock, @Transaction," +
                                      "@DrCode, @Quantity, @UnitPrice," +
                                      "@Secret, @TotalAmount, @Discharged ";

                #region Load tto data inserted parameters add
                command.Parameters.Add("@ShipmentDate", SqlDbType.VarChar, 10).Value = sevk.ShipmentDate.ToString();
                command.Parameters.Add("@FileNumber", SqlDbType.VarChar, 50).Value = sevk.FileNumber.ToString();
                command.Parameters.Add("@Polyclinic", SqlDbType.VarChar, 50).Value = sevk.Polyclinic.ToString();
                command.Parameters.Add("@Clock", SqlDbType.VarChar, 10).Value = sevk.Clock.ToString();
                command.Parameters.Add("@Transaction", SqlDbType.VarChar, 50).Value = sevk.Transaction.ToString();
                command.Parameters.Add("@DrCode", SqlDbType.Char, 10).Value = sevk.DrCode.ToString();
                command.Parameters.Add("@Quantity", SqlDbType.Char, 3).Value = sevk.Quantity.ToString();
                command.Parameters.Add("@UnitPrice", SqlDbType.VarChar, 20).Value = sevk.UnitPrice.ToString();
                command.Parameters.Add("@Secret", SqlDbType.VarChar, 3).Value = sevk.Secret.ToString();
                command.Parameters.Add("@TotalAmount", SqlDbType.VarChar, 50).Value = sevk.TotalAmount.ToString();
                command.Parameters.Add("@Discharged", SqlDbType.VarChar, 50).Value = sevk.Discharged.ToString();
                #endregion

                ConnectionDB.ConnectionToDatabase();
                command.ExecuteNonQuery();
                ConnectionDB.EndConnectionToDatabase();

                return true;
            }

        }
        #endregion

        #region SelectDischarged --> sevk tablosundaki bilgilerin getirilmesi sağlanıyor.
        public List<sevk> SelectDischarged(string fileNumber, string makeATransaction)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Stored Prosedure tanımlaması yapılmaktadır ..
            if (fileNumber == null || fileNumber == "")
                command = new SqlCommand("[dbo].[_selGetDischarged]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[sel_GetDischargedToFileNumber]", ConnectionDB._connection);
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

            #region Load to reader data
            reader = command.ExecuteReader();
            List<sevk> patients = new List<sevk>();
            while (reader.Read())
            {
                sevk patient = new sevk();
                patient.Polyclinic = reader["Polyclinic"].ToString();
                patient.Secret = reader["Secret"].ToString();
                patient.Clock = reader["Clock"].ToString();
                patient.Transaction = reader["Transaction"].ToString();
                patient.DrCode = reader["DrCode"].ToString();
                patient.Quantity = reader["Quantity"].ToString();
                patient.UnitPrice = reader["UnitPrice"].ToString();
                patient.ShipmentDate = reader["ShipmentDate"].ToString();    
                patients.Add(patient);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return patients;
        }
        #endregion

        #region SelectShipmentDateTo --> sevk tablosundaki bilgiler tarihe göre getiriliyor ..
        public List<sevk> SelectShipmentDateTo(string shipmentDate)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Stored Prosedure tanımlaması yapılmaktadır ..
            if (shipmentDate == null)
                command = new SqlCommand("[dbo].[_selGetDischarged]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[sel_GetDischargedToShipmentDate]", ConnectionDB._connection);
                command.CommandType = CommandType.StoredProcedure;
                parameter = new SqlParameter("@ShipmentDate", shipmentDate);
                parameter.Direction = ParameterDirection.Input;
                parameter.DbType = DbType.String;
                command.Parameters.Add(parameter);
            }
            #endregion

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            command.ExecuteNonQuery();

            #region Load to reader data
            reader = command.ExecuteReader();
            List<sevk> patients = new List<sevk>();
            while (reader.Read())
            {
                sevk patient = new sevk();
                patient.Polyclinic = reader["Polyclinic"].ToString();
                patient.Secret = reader["Secret"].ToString();
                patient.Clock = reader["Clock"].ToString();
                patient.Transaction = reader["Transaction"].ToString();
                patient.DrCode = reader["DrCode"].ToString();
                patient.Quantity = reader["Quantity"].ToString();
                patient.UnitPrice = reader["UnitPrice"].ToString();
                patient.ShipmentDate = reader["ShipmentDate"].ToString();
                patients.Add(patient);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return patients;

        }
        #endregion

        #region GetDischargedDateTimeTo -->sevk tablosundaki bilgiler getirilir.
        public List<sevk> GetDischargedDateTimeTo(string discharged)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Strored Prosedure tanımlaması yapılmaktadır .. 
            if (discharged == null)
                command = new SqlCommand("[dbo].[_selGetDischarged]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[GetDischargedDateTimeTo]", ConnectionDB._connection);
                parameter = new SqlParameter("@taburcu", discharged);
                command.CommandType = CommandType.StoredProcedure;

                parameter.Direction = ParameterDirection.Input;
                parameter.DbType = DbType.String;
                command.Parameters.Add(parameter);
            }
            #endregion

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            command.ExecuteNonQuery();

            #region Load to reader data
            reader = command.ExecuteReader();
            List<sevk> sevkLists = new List<sevk>();

            while (reader.Read())
            {
                sevk sevkDis = new sevk();
                sevkDis.ShipmentDate = reader["ShipmentDate"].ToString();
                sevkDis.Polyclinic = reader["Polyclinic"].ToString();
                sevkDis.Clock = reader["Clock"].ToString();
                sevkDis.DrCode = reader["DrCode"].ToString();
                sevkDis.Quantity = reader["Quantity"].ToString();
                sevkDis.UnitPrice = reader["UnitPrice"].ToString();
                sevkDis.Secret = reader["Secret"].ToString();
                sevkDis.TotalAmount = reader["TotalAmount"].ToString();
                sevkLists.Add(sevkDis);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return sevkLists;

        }
        #endregion

        #region GetFindQueue --> Sıra numarası ayarlanmaktadır.
        public DataTable GetFindQueue(string poliklinikWord, int poliklinikSira)
        {
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("[dbo].[GetQueue]", ConnectionDB._connection);
            adapter.SelectCommand.Parameters.AddWithValue("@Polynclinic", poliklinikWord);
            adapter.SelectCommand.Parameters.AddWithValue("@Queue", poliklinikSira);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(dataTable);

            return dataTable;
        }
        #endregion

        #region DeletePatientDataGridSelected --> Gelen dosya numarasına göre silme işlemi gerçekleşmektedir.
        public bool DeletePatientDataGridSelected(string FileNumber)
        {
            ConnectionDB.ConnectionToDatabase();
            SqlCommand command;

            command = new SqlCommand("[dbo].[_delPatientSelected]", ConnectionDB._connection);
            command.CommandType = CommandType.StoredProcedure;
            parameter = new SqlParameter("@FileNumber", FileNumber);
            parameter.Direction = ParameterDirection.Input;
            parameter.DbType = DbType.String;

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            command.ExecuteNonQuery();

            reader = command.ExecuteReader();
            ConnectionDB.EndConnectionToDatabase();

            return true;
        }
        #endregion
    }
}
