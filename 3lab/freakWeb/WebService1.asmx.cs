using dll;
using System;
using System.ComponentModel;
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
        public int CreateCars(string metal, int age, string model, bool @break, int places)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlInsertMachine = "INSERT INTO Machines (Metal, Age, [Break]) VALUES (@Metal, @Age, @Break); SELECT SCOPE_IDENTITY();";
                int machineId;
                using (SqlCommand command = new SqlCommand(sqlInsertMachine, connection))
                {
                    command.Parameters.Add("@Metal", SqlDbType.NVarChar, 50).Value = metal;
                    command.Parameters.Add("@Age", SqlDbType.Int).Value = age;
                    command.Parameters.Add("@Break", SqlDbType.Bit).Value = @break;
                    machineId = Convert.ToInt32(command.ExecuteScalar());
                }


                string sql = "INSERT INTO Car (Model, Places, Id) VALUES (@Model, @Places, @Id); SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = machineId;
                    command.Parameters.Add("@Model", SqlDbType.NVarChar, 50).Value = model;
                    command.Parameters.Add("@Places", SqlDbType.Int).Value = places;
                    command.ExecuteNonQuery();
                    return machineId;
                }
            }
        }

        [WebMethod]
        public BindingList<Car> GetAllCars()
        {
            BindingList<Car> cars = new BindingList<Car>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Car";

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

