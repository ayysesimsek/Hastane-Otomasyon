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
    public class PoliklinikContract
    {
        public SqlCommand command;
        public SqlDataAdapter adaptor;
        public SqlDataReader reader;
        public SqlParameter parameter;

        #region GetPoliklinik --> Poliklinik tablosundan veriler çekiliyor.
        public List<poliklinik> GetPoliklinik(string polyclinicName)
        {
            ConnectionDB.ConnectionToDatabase();

            #region Stored Prosedure tanımlaması yapılmaktadır .. 
            if (polyclinicName == null)
                command = new SqlCommand("[dbo].[sel_GetPolynclinic]", ConnectionDB._connection);
            else
            {
                command = new SqlCommand("[dbo].[sel_GetPolynclinicName]", ConnectionDB._connection);
                command.CommandType = CommandType.StoredProcedure;
                parameter = new SqlParameter("@PolyclinicName", polyclinicName);
                parameter.Direction = ParameterDirection.Input;
                parameter.DbType = DbType.String;
                command.Parameters.Add(parameter);
            }
            #endregion

            adaptor = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            command.ExecuteNonQuery();

            #region Load to reader data
            reader = command.ExecuteReader();
            List<poliklinik> polyclinics = new List<poliklinik>();
            while (reader.Read())
            {
                poliklinik pol = new poliklinik();
                pol.PolyclinicName = reader[0].ToString();
                pol.Status = reader[1].ToString();
                pol.Description = reader[2].ToString();
                pol.PoliklinikID = Convert.ToInt32(reader[3]);
                polyclinics.Add(pol);
            }
            #endregion

            ConnectionDB.EndConnectionToDatabase();
            return polyclinics;
        }
        #endregion

        #region InsertPolyclinic --> poliklinik tablosuna veri kaydı yapılmaktadır.
        public bool InsertPolyclinic(poliklinik poliklinik)
        {
            if (poliklinik == null)
                return false;
            else
            {
                SqlCommand command = ConnectionDB._connection.CreateCommand();
                command.CommandText = "Execute [dbo].[_insPolyclinicName]" +
                                      "@PolyclinicName, @Status, @Description";

                command.Parameters.Add("@PolyclinicName", SqlDbType.VarChar, 15).Value = poliklinik.PolyclinicName.ToString();
                command.Parameters.Add("@Status", SqlDbType.VarChar, 5).Value = poliklinik.Status.ToString();
                command.Parameters.Add("@Description", SqlDbType.VarChar, 255).Value = poliklinik.Description.ToString();
               
                ConnectionDB.ConnectionToDatabase();
                command.ExecuteNonQuery();
                ConnectionDB.EndConnectionToDatabase();

                return true;
            }
        }
        #endregion

        #region DeletePolyclinic --> Poliklinik Silme işlemi gerçekleşmektdir. 
        public bool DeletePolyclinic(int ID)
        {
            ConnectionDB.ConnectionToDatabase();
            SqlCommand command;

            command = new SqlCommand("[dbo].[_delPoliklinik]", ConnectionDB._connection);
            command.CommandType = CommandType.StoredProcedure;
            parameter = new SqlParameter("@PoliklinikID", ID);
            parameter.Direction = ParameterDirection.Input;
            parameter.DbType = DbType.Int32;
            command.Parameters.Add(parameter);

            adaptor = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            command.ExecuteNonQuery();

            reader = command.ExecuteReader();
            ConnectionDB.EndConnectionToDatabase();

            return true;
        }
        #endregion

        #region UpdatePolyclinic --> Poliklinik Güncelleme işlemi gerçekleşmektedir.
        public bool UpdatePolyclinic(poliklinik pol)
        {
            ConnectionDB.ConnectionToDatabase();
            SqlCommand command;

            command = ConnectionDB._connection.CreateCommand();
            command.CommandText = "Execute [dbo].[_updPoliklinik] " +
                                  "@PoliklinikID, @PolyclinicName, @Status, @Description";

            command.Parameters.Add("@PoliklinikID", SqlDbType.Int).Value = pol.PoliklinikID;
            command.Parameters.Add("@PolyclinicName", SqlDbType.VarChar, 20).Value = pol.PolyclinicName;
            command.Parameters.Add("@Status", SqlDbType.VarChar, 5).Value = pol.Status;
            command.Parameters.Add("@Description", SqlDbType.VarChar, 255).Value = pol.Description;

            ConnectionDB.ConnectionToDatabase();
            command.ExecuteNonQuery();
            ConnectionDB.EndConnectionToDatabase();

            return true;
        }
        #endregion 
    }
}
