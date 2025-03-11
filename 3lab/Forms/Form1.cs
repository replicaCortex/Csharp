
using Forms.ServiceReference1;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Forms
{
    public partial class Form1 : Form
    {
        private BindingList<Car> car_list = new BindingList<Car>();
        public int count_car = 1;
        public Form1()
        {
            InitializeComponent();
            // dataGridView1.DataSource = car_list;
            comboBox1.Items.AddRange(new object[] { "id", "Metal", "Age", "Break" });
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            string chouse = comboBox1.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White; // сброс цвета

                if (row.Cells[chouse].Value?.ToString() == searchValue)
                {
                    row.DefaultCellStyle.BackColor = Color.Tan;
                }
            }
        }

        private void ClearShearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void CreateCustomCar_Click_1(object sender, EventArgs e)
        {
            bool Break = inputBreak.Checked;

            string Model = inputModel.Text;
            string Metal = inputMetal.Text;
            int Age = int.Parse(inputAge.Text);
            int places = int.Parse(inputPlaces.Text);

            using (WebService1SoapClient client = new WebService1SoapClient())
            {
                client.CreateCars(Metal, Age, Model, Break, places);
            }
        }
        private void SaveCarToXml(BindingList<Car> car, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Car>));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, car);
            }
        }

        private BindingList<Car> LoadCarFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Car>));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (BindingList<Car>)serializer.Deserialize(reader);
            }
        }

        private void Grid2xml_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCarToXml(car_list, saveDialog.FileName);
            }
        }

        private void Xml2grid_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                car_list = LoadCarFromXml(openDialog.FileName);
                dataGridView1.DataSource = car_list;
            }
        }

        private void CreateTestCar_Click_1(object sender, EventArgs e)
        {
            Car car = new Car
            {
                id = count_car,
                Model = "Tesla",
                Metal = "Aluminum",
                Age = 2,
                Break = false,
            };
            car_list.Add(car);
            count_car++;
        }


        private async void Sql2grid_Click(object sender, EventArgs e)
        {
            WebService1SoapClient client = new WebService1SoapClient();

            ServiceReference1.GetAllCarsResponse response = await client.GetAllCarsAsync();

            BindingList<ServiceReference1.Car> cars = new BindingList<ServiceReference1.Car>(response.Body.GetAllCarsResult);

            dataGridView1.DataSource = cars;

            if (client.State != System.ServiceModel.CommunicationState.Faulted)
            {
                client.Close();
            }
        }

    }
}

