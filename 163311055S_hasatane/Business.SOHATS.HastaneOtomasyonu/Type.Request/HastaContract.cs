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
    public class HastaContract
    {
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public SqlParameter parameter;

        #region GetPatient --> hasta tablosundaki bilgilerin getirilmesi sağlanıyor...
        public List<hasta> GetPatient(string FileNumber)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Stored Prosedure bağlantısı 
            if (FileNumber == null)
                command = new SqlCommand("[dbo].[_selGetPatient]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[_selGetPatientPrimaryKey]", ConnectionDB._connection);
                command.CommandType = CommandType.StoredProcedure;
                parameter = new SqlParameter("@FileNumber", FileNumber);
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
            List<hasta> patients = new List<hasta>();
            while (reader.Read())
            {
                hasta patient = new hasta();
                patient.TCKN = reader["TCKN"].ToString();
                patient.FileNumber = reader["FileNumber"].ToString();
                patient.Name = reader["Name"].ToString();
                patient.SurName = reader["SurName"].ToString();
                patient.PlaceOfBirth = reader["PlaceOfBirth"].ToString();
                patient.DateOfBirth = (DateTime)reader["DateOfBirth"];
                patient.FatherName = reader["FatherName"].ToString();
                patient.MotherName = reader["MotherName"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.BloodGroup = reader["BloodGroup"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.MobilePhone = reader["MobilePhone"].ToString();
                patient.FoundationRegistrationNumber = reader["FoundationRegistrationNumber"].ToString();
                patient.FoundationName = reader["FoundationName"].ToString();
                patient.CloseMobilePhone = reader["CloseMobilePhone"].ToString();
                patient.CloseFoundationRegistrationNumber = reader["CloseFoundationRegistrationNumber"].ToString();
                patient.CloseFoundationName = reader["CloseFoundationName"].ToString();
                patients.Add(patient);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return patients;
        }
        #endregion

        #region InsertPatientProcess --> hasta tablosuna veri kaydı yapılmaktadır.
        public bool InsertPatientProcess(hasta hasta)
        {
            if (hasta == null)
                return false;
            else
            {
                SqlCommand command = ConnectionDB._connection.CreateCommand();
                command.CommandText = "Execute [dbo].[_insPatient]" +
                                      "@TCKN, @FileNumber, @Name," +
                                      "@SurName, @PlaceOfbirth, @DateOfBirth," +
                                      "@FatherName, @MotherName, @Gender," +
                                      "@BloodGroup, @Address,@MobilePhone," +
                                      "@FoundationRegistrationNumber, @FoundationName, @CloseMobilePhone," +
                                      "@CloseFoundationRegistrationNumber, @CloseFoundationName";

                #region Inserted command data
                command.Parameters.Add("@TCKN", SqlDbType.VarChar, 10).Value = hasta.TCKN.ToString();
                command.Parameters.Add("@FileNumber", SqlDbType.VarChar, 10).Value = hasta.FileNumber.ToString();
                command.Parameters.Add("@Name", SqlDbType.VarChar, 15).Value = hasta.Name.ToString();
                command.Parameters.Add("@SurName", SqlDbType.VarChar, 15).Value = hasta.SurName.ToString();
                command.Parameters.Add("@PlaceOfBirth", SqlDbType.VarChar, 15).Value = hasta.PlaceOfBirth.ToString();
                command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = (DateTime)hasta.DateOfBirth;
                command.Parameters.Add("@FatherName", SqlDbType.VarChar, 15).Value = hasta.FatherName.ToString();
                command.Parameters.Add("@MotherName", SqlDbType.VarChar, 15).Value = hasta.MotherName.ToString();
                command.Parameters.Add("@Gender", SqlDbType.VarChar, 5).Value = hasta.Gender.ToString();
                command.Parameters.Add("@BloodGroup", SqlDbType.VarChar, 5).Value = hasta.BloodGroup.ToString();
                command.Parameters.Add("@Address", SqlDbType.VarChar, 255).Value = hasta.Address.ToString();
                command.Parameters.Add("@MobilePhone", SqlDbType.VarChar, 11).Value = hasta.MobilePhone.ToString();
                command.Parameters.Add("@FoundationRegistrationNumber", SqlDbType.VarChar, 10).Value = hasta.FoundationRegistrationNumber.ToString();
                command.Parameters.Add("@FoundationName", SqlDbType.VarChar, 50).Value = hasta.FoundationName.ToString();
                command.Parameters.Add("@CloseMobilePhone", SqlDbType.VarChar, 11).Value = hasta.CloseMobilePhone.ToString();
                command.Parameters.Add("@CloseFoundationRegistrationNumber", SqlDbType.VarChar, 10).Value = hasta.CloseFoundationRegistrationNumber.ToString();
                command.Parameters.Add("@CloseFoundationName", SqlDbType.VarChar, 50).Value = hasta.CloseFoundationName.ToString();
                #endregion

                ConnectionDB.ConnectionToDatabase();
                command.ExecuteNonQuery();
                ConnectionDB.EndConnectionToDatabase();

                return true;
            }
        }
        #endregion

        #region NameToGetPatient --> Ada göre arama yapıldığı zaman tanımlanan metottur. hasta tablosundan veriler ada göre getirilmektedir.
        public List<hasta> NameToGetPatient(string name)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Stored Prosedure bağlantısı 
            if (name == null)
                command = new SqlCommand("[dbo].[_selGetPatient]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[sel_GetNameOrSurName]", ConnectionDB._connection);
                command.CommandType = CommandType.StoredProcedure;
                parameter = new SqlParameter("@Name", name);
                parameter.Direction = ParameterDirection.Input;
                parameter.DbType = DbType.String;
                command.Parameters.Add(parameter);
            }
            #endregion

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            command.ExecuteNonQuery();

            reader = command.ExecuteReader();
            List<hasta> patients = new List<hasta>();

            #region Load to data reader
            while (reader.Read())
            {
                hasta patient = new hasta();
                patient.FullName = reader["FullName"].ToString();
                patient.TCKN = reader["TCKN"].ToString();
                patient.FileNumber = reader["FileNumber"].ToString();
                patient.Name = reader["Name"].ToString();
                patient.SurName = reader["SurName"].ToString();
                patient.PlaceOfBirth = reader["PlaceOfBirth"].ToString();
                patient.DateOfBirth = (DateTime)reader["DateOfBirth"];
                patient.FatherName = reader["FatherName"].ToString();
                patient.MotherName = reader["MotherName"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.BloodGroup = reader["BloodGroup"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.MobilePhone = reader["MobilePhone"].ToString();
                patient.FoundationRegistrationNumber = reader["FoundationRegistrationNumber"].ToString();
                patient.FoundationName = reader["FoundationName"].ToString();
                patient.CloseMobilePhone = reader["CloseMobilePhone"].ToString();
                patient.CloseFoundationRegistrationNumber = reader["CloseFoundationRegistrationNumber"].ToString();
                patient.CloseFoundationName = reader["CloseFoundationName"].ToString();
                patients.Add(patient);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return patients;
        }
        #endregion

        #region TCKNToGetPatient --> TCKN' ye göre filtreleme yapılmaktadır .. 
        public List<hasta> TCKNToGetPatient(string tckn)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Stored Prosedure bağlantısı 
            if (tckn == null)
                command = new SqlCommand("[dbo].[_selGetPatient]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[sel_GetTCKN]", ConnectionDB._connection);
                command.CommandType = CommandType.StoredProcedure;
                parameter = new SqlParameter("@TCKN", tckn);
                parameter.Direction = ParameterDirection.Input;
                parameter.DbType = DbType.String;
                command.Parameters.Add(parameter);
            }
            #endregion

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            command.ExecuteNonQuery();

            reader = command.ExecuteReader();
            List<hasta> patients = new List<hasta>();

            #region Load to data reader
            while (reader.Read())
            {
                hasta patient = new hasta();
                patient.TCKN = reader["TCKN"].ToString();
                patient.FileNumber = reader["FileNumber"].ToString();
                patient.Name = reader["Name"].ToString();
                patient.SurName = reader["SurName"].ToString();
                patient.PlaceOfBirth = reader["PlaceOfBirth"].ToString();
                patient.DateOfBirth = (DateTime)reader["DateOfBirth"];
                patient.FatherName = reader["FatherName"].ToString();
                patient.MotherName = reader["MotherName"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.BloodGroup = reader["BloodGroup"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.MobilePhone = reader["MobilePhone"].ToString();
                patient.FoundationRegistrationNumber = reader["FoundationRegistrationNumber"].ToString();
                patient.FoundationName = reader["FoundationName"].ToString();
                patient.CloseMobilePhone = reader["CloseMobilePhone"].ToString();
                patient.CloseFoundationRegistrationNumber = reader["CloseFoundationRegistrationNumber"].ToString();
                patient.CloseFoundationName = reader["CloseFoundationName"].ToString();
                patients.Add(patient);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return patients;
        }
        #endregion

        #region FoundationRegistrationNumberToGet --> Kurum Sici No'ya göre filtreleme yapılmaktadır.. 
        public List<hasta> FoundationRegistrationNumberToGet(string number)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Stored Prosedure bağlantısı 
            if (number == null)
                command = new SqlCommand("[dbo].[_selGetPatient]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[sel_GetFoundationRegistrationNumber]", ConnectionDB._connection);
                command.CommandType = CommandType.StoredProcedure;
                parameter = new SqlParameter("@FoundationRegistrationNumber", number);
                parameter.Direction = ParameterDirection.Input;
                parameter.DbType = DbType.String;
                command.Parameters.Add(parameter);
            }
            #endregion

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            command.ExecuteNonQuery();

            reader = command.ExecuteReader();
            List<hasta> patients = new List<hasta>();

            #region Load to data reader
            while (reader.Read())
            {
                hasta patient = new hasta();
                patient.TCKN = reader["TCKN"].ToString();
                patient.FileNumber = reader["FileNumber"].ToString();
                patient.Name = reader["Name"].ToString();
                patient.SurName = reader["SurName"].ToString();
                patient.PlaceOfBirth = reader["PlaceOfBirth"].ToString();
                patient.DateOfBirth = (DateTime)reader["DateOfBirth"];
                patient.FatherName = reader["FatherName"].ToString();
                patient.MotherName = reader["MotherName"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.BloodGroup = reader["BloodGroup"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.MobilePhone = reader["MobilePhone"].ToString();
                patient.FoundationRegistrationNumber = reader["FoundationRegistrationNumber"].ToString();
                patient.FoundationName = reader["FoundationName"].ToString();
                patient.CloseMobilePhone = reader["CloseMobilePhone"].ToString();
                patient.CloseFoundationRegistrationNumber = reader["CloseFoundationRegistrationNumber"].ToString();
                patient.CloseFoundationName = reader["CloseFoundationName"].ToString();
                patients.Add(patient);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return patients;
        }
        #endregion

        #region FileNumberToGetInformation --> Dosya numarasına göre filtreleme yapılmaktadır... 
        public List<hasta> FileNumberToGetInformation(string fileNumber)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Stored Prosedure bağlantısı 
            if (fileNumber == null)
                command = new SqlCommand("[dbo].[_selGetPatient]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[sel_GetPatientFileNumber]", ConnectionDB._connection);
                command.CommandType = CommandType.StoredProcedure;
                parameter = new SqlParameter("@FileNumber", fileNumber);
                parameter.DbType = DbType.String;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);
            }
            #endregion

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            command.ExecuteNonQuery();

            reader = command.ExecuteReader();
            List<hasta> patients = new List<hasta>();

            #region Load to data reader
            while (reader.Read())
            {
                hasta patient = new hasta();
                patient.TCKN = reader["TCKN"].ToString();
                patient.FileNumber = reader["FileNumber"].ToString();
                patient.Name = reader["Name"].ToString();
                patient.SurName = reader["SurName"].ToString();
                patient.PlaceOfBirth = reader["PlaceOfBirth"].ToString();
                patient.DateOfBirth = (DateTime)reader["DateOfBirth"];
                patient.FatherName = reader["FatherName"].ToString();
                patient.MotherName = reader["MotherName"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.BloodGroup = reader["BloodGroup"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.MobilePhone = reader["MobilePhone"].ToString();
                patient.FoundationRegistrationNumber = reader["FoundationRegistrationNumber"].ToString();
                patient.FoundationName = reader["FoundationName"].ToString();
                patient.CloseMobilePhone = reader["CloseMobilePhone"].ToString();
                patient.CloseFoundationRegistrationNumber = reader["CloseFoundationRegistrationNumber"].ToString();
                patient.CloseFoundationName = reader["CloseFoundationName"].ToString();
                patients.Add(patient);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return patients;
        }
        #endregion
    }
}
