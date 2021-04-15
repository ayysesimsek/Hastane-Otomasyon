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
    public class KullaniciContract
    {
        public SqlCommand command;
        public SqlDataAdapter adaptor;
        public SqlDataReader reader;
        public SqlParameter parameter;

        #region GetUser -->  kullanici tablosundaki bilgileri seçme işlemi yapılmaktadır.
        public List<kullanici> GetUser(string code)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Stored Prosedure tanımlanıyor ..
            if (code == null)
                command = new SqlCommand("_selLogin", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[_selUserPrimaryKey]", ConnectionDB._connection);
                command.CommandType = CommandType.StoredProcedure;
                parameter = new SqlParameter("@Code", code);
                parameter.Direction = ParameterDirection.Input;
                parameter.DbType = DbType.String;
                command.Parameters.Add(parameter);
            }
            #endregion

            adaptor = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            command.ExecuteNonQuery();

            #region Fill all to Data Reader
            reader = command.ExecuteReader();
            List<kullanici> users = new List<kullanici>();
            while (reader.Read())
            {
                kullanici user = new kullanici();
                user.Code = reader[0].ToString();
                user.Name = reader[1].ToString();
                user.SurName = reader[2].ToString();
                user.Password = reader[3].ToString();
                user.Authority = reader[4].ToString();
                user.HomePhone = reader[5].ToString();
                user.MobilePhone = reader[6].ToString();
                user.Address = reader[7].ToString();
                user.Title = reader[8].ToString();
                user.Salary = reader[10].ToString();
                user.PlateOfBirthh = reader[11].ToString();
                user.MotherName = reader[12].ToString();
                user.FatherName = reader[13].ToString();
                user.Gender = reader[14].ToString();
                user.BloodGroup = reader[15].ToString();
                user.MarialStatus = reader[16].ToString();
                user.DateOfBirth = (DateTime)reader[17];
                user.TCKN = reader[18].ToString();
                user.UserName = reader[19].ToString();
                users.Add(user);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return users;
        }
        #endregion

        #region InsertUserTable --> kullanici tablosuna veri kaydı yapılmaktadır.
        public bool InsertUserTable(kullanici user)
        {
            if (user == null)
                return false;
            else
            {
                SqlCommand command = ConnectionDB._connection.CreateCommand();
                command.CommandText = "Execute [dbo].[_insUser] " +
                                      "@Code, @Name, @SurName," +
                                      "@Password, @Authority, @HomePhone," +
                                      "@MobilePhone, @Address, @Title," +
                                      "@StartWork, @Salary, @PlateOfBirth," +
                                      "@MotherName, @FatherName, @Gender," +
                                      "@BloodGroup, @MarialStatus, @DateOfBirth," +
                                      "@TCKN, @UserName";

                #region Fill to load parameter add 
                command.Parameters.Add("@Code", SqlDbType.VarChar, 20).Value = user.Code.ToString();
                command.Parameters.Add("@Name", SqlDbType.VarChar, 20).Value = user.Name.ToString();
                command.Parameters.Add("@SurName", SqlDbType.VarChar, 20).Value = user.SurName.ToString();
                command.Parameters.Add("@Password", SqlDbType.VarChar, 20).Value = user.Password.ToString();
                command.Parameters.Add("@Authority", SqlDbType.VarChar, 5).Value = user.Authority.ToString();
                command.Parameters.Add("@HomePhone", SqlDbType.VarChar, 11).Value = user.HomePhone.ToString();
                command.Parameters.Add("@MobilePhone", SqlDbType.VarChar, 11).Value = user.MobilePhone.ToString();
                command.Parameters.Add("@Address", SqlDbType.VarChar, 255).Value = user.Address.ToString();
                command.Parameters.Add("@Title", SqlDbType.VarChar, 15).Value = user.Title.ToString();
                command.Parameters.Add("@StartWork", SqlDbType.DateTime).Value = (DateTime)user.StartWork;
                command.Parameters.Add("@Salary", SqlDbType.VarChar, 20).Value = user.Salary.ToString();
                command.Parameters.Add("@PlateOfBirth", SqlDbType.VarChar, 50).Value = user.PlateOfBirthh.ToString();
                command.Parameters.Add("@MotherName", SqlDbType.VarChar, 20).Value = user.MotherName.ToString();
                command.Parameters.Add("@FatherName", SqlDbType.VarChar, 20).Value = user.FatherName.ToString();
                command.Parameters.Add("@Gender", SqlDbType.VarChar, 5).Value = user.Gender.ToString();
                command.Parameters.Add("@BloodGroup", SqlDbType.VarChar, 10).Value = user.BloodGroup.ToString();
                command.Parameters.Add("@MarialStatus", SqlDbType.VarChar, 10).Value = user.MarialStatus.ToString();
                command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = (DateTime)user.DateOfBirth;
                command.Parameters.Add("@TCKN", SqlDbType.VarChar, 11).Value = user.TCKN.ToString();
                command.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = user.UserName.ToString();
                #endregion
                
                ConnectionDB.ConnectionToDatabase();
                command.ExecuteNonQuery();
                ConnectionDB.EndConnectionToDatabase();

                return true;
            }
        }
        #endregion

        #region UpdateUserTable --> Kişi tablosunda güncelleme işlemi yapılmaktadır. 
        public bool UpdateUserTable(kullanici user)
        {
            if (user == null)
                return false;
            else
            {
                ConnectionDB.ConnectionToDatabase();
                SqlCommand command;

                command = ConnectionDB._connection.CreateCommand();
                command.CommandText = "Execute [dbo].[_updUser] " +
                                      "@Code, @Name, @SurName," +
                                      "@Password, @Authority, @HomePhone," +
                                      "@MobilePhone, @Address, @Title," +
                                      "@StartWork, @Salary, @PlateOfBirth," +
                                      "@MotherName, @FatherName, @Gender," +
                                      "@BloodGroup, @MarialStatus, @DateOfBirth," +
                                      "@TCKN, @UserName";

                #region Load to data updated parameters add
                command.Parameters.Add("@Code", SqlDbType.VarChar, 20).Value = user.Code.ToString();
                command.Parameters.Add("@Name", SqlDbType.VarChar, 20).Value = user.Name.ToString();
                command.Parameters.Add("@SurName", SqlDbType.VarChar, 20).Value = user.SurName.ToString();
                command.Parameters.Add("@Password", SqlDbType.VarChar, 20).Value = user.Password.ToString();
                command.Parameters.Add("@Authority", SqlDbType.VarChar, 5).Value = user.Authority.ToString();
                command.Parameters.Add("@HomePhone", SqlDbType.VarChar, 11).Value = user.HomePhone.ToString();
                command.Parameters.Add("@MobilePhone", SqlDbType.VarChar, 11).Value = user.MobilePhone.ToString();
                command.Parameters.Add("@Address", SqlDbType.VarChar, 255).Value = user.Address.ToString();
                command.Parameters.Add("@Title", SqlDbType.VarChar, 15).Value = user.Title.ToString();
                command.Parameters.Add("@StartWork", SqlDbType.DateTime).Value = (DateTime)user.StartWork;
                command.Parameters.Add("@Salary", SqlDbType.VarChar, 20).Value = user.Salary.ToString();
                command.Parameters.Add("@PlateOfBirth", SqlDbType.VarChar, 50).Value = user.PlateOfBirthh.ToString();
                command.Parameters.Add("@MotherName", SqlDbType.VarChar, 20).Value = user.MotherName.ToString();
                command.Parameters.Add("@FatherName", SqlDbType.VarChar, 20).Value = user.FatherName.ToString();
                command.Parameters.Add("@Gender", SqlDbType.VarChar, 5).Value = user.Gender.ToString();
                command.Parameters.Add("@BloodGroup", SqlDbType.VarChar, 10).Value = user.BloodGroup.ToString();
                command.Parameters.Add("@MarialStatus", SqlDbType.VarChar, 10).Value = user.MarialStatus.ToString();
                command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = (DateTime)user.DateOfBirth;
                command.Parameters.Add("@TCKN", SqlDbType.VarChar, 11).Value = user.TCKN.ToString();
                command.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = user.UserName.ToString();
                #endregion

                ConnectionDB.ConnectionToDatabase();
                command.ExecuteNonQuery();
                ConnectionDB.EndConnectionToDatabase();

                return true;
            }
        }
        #endregion

        #region DeletedUser --> Kişi Silmek için metot tanımlanmıştır.
        public void DeletedUser(string code)
        {
            ConnectionDB.ConnectionToDatabase();
            SqlCommand command;
            command = new SqlCommand("[dbo].[_delUserCode]", ConnectionDB._connection);
            command.CommandType = CommandType.StoredProcedure;

            parameter = new SqlParameter("@Code", code);
            parameter.Direction = ParameterDirection.Input;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            adaptor = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            command.ExecuteNonQuery();

            reader = command.ExecuteReader();
            ConnectionDB.EndConnectionToDatabase();
        }
        #endregion
    }
}
