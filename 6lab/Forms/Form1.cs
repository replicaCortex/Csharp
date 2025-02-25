using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Serialization;
using dll;
using Forms.Workflow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Forms
{
    public partial class Form1: Form
    {
        private BindingList<Car> car_list = new BindingList<Car>();
        public int count_car = 1;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = car_list;
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

            Car car = new Car
            {
                id = count_car,
                Model = inputModel.Text,
                Metal = inputAge.Text,
                Age = int.Parse(inputAge.Text),
                Break = Break,
            };
            car_list.Add(car);
            count_car++;
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

        private void TestWWF_Click(object sender, EventArgs e)
        {
            bool Break = inputBreak.Checked;
            int id = count_car;
            string Model = inputModel.Text;
            string Metal = inputAge.Text;
            int Age = int.Parse(inputAge.Text);

            CarWorkflow workflow = new CarWorkflow(Model, Metal, Age, Break);

            // IDictionary<string, object> outputs = WorkflowInvoker.Invoke(workflowActivity);


        }
    }

}

