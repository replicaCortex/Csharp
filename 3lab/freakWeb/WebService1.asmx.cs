using dll;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace freakWeb
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]


    public class WebService1 : System.Web.Services.WebService
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        [WebMethod]
        public int CreateMachine(string metal, int age, bool @break)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Machines (Metal, Age, [Break]) VALUES (@Metal, @Age, @Break); SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@Metal", SqlDbType.NVarChar, 50).Value = metal;
                    command.Parameters.Add("@Age", SqlDbType.Int).Value = age;
                    command.Parameters.Add("@Break", SqlDbType.Bit).Value = @break;
                    int newId = Convert.ToInt32(command.ExecuteScalar());
                    return newId;
                }
            }
        }
        [WebMethod]
        public int CreateCars(string metal, int age, bool drive, int engineId, bool @break)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlInsertMachine = "INSERT INTO Machines (Metal, Age, [Break]) VALUES (@Metal, @Age, @Break); SELECT SCOPE_IDENTITY();";
                int machineId;
                using (SqlCommand command = new SqlCommand(sqlInsertMachine, connection))
                {
                    command.Parameters.Add("@Metal", SqlDbType.NVarChar, 50).Value = metal ?? (object)DBNull.Value;
                    command.Parameters.Add("@Age", SqlDbType.Int).Value = age;
                    command.Parameters.Add("@Break", SqlDbType.Bit).Value = @break;
                    machineId = Convert.ToInt32(command.ExecuteScalar());
                }


                string sql = "INSERT INTO Cars (Model, Places, Drive, EngineId, Id) VALUES (@Model, @Places, @Drive, @EngineId, @Id); SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = machineId;
                    command.Parameters.Add("@Model", SqlDbType.NVarChar, 50).Value = metal;
                    command.Parameters.Add("@Places", SqlDbType.Int).Value = age;
                    command.Parameters.Add("@Drive", SqlDbType.Bit).Value = drive;
                    command.Parameters.Add("@EngineId", SqlDbType.Int).Value = engineId;
                    command.ExecuteNonQuery();
                    return machineId;
                }
            }
        }

        [WebMethod]
        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Cars";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car car = new Car
                            {
                                id = (int)reader["Id"],
                                Model = reader["Model"] == DBNull.Value ? null : (string)reader["Model"],
                                Places = reader["Places"] == DBNull.Value ? 0 : (int)reader["Places"],
                                Drive = reader["Drive"] == DBNull.Value ? false : (bool)reader["Drive"],

                            };
                            cars.Add(car);
                        }
                    }
                }
            }
            return cars;
        }
    }
}

