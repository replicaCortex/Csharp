using dll;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Numerics;
using System.Reflection;
using System.ComponentModel;
using System.Windows.Forms;
using System.Buffers;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace lab2
{
    public partial class Form1 : Form
    {
        private BindingList<Car> car_list = new BindingList<Car>();

        public Form1()
        {

            InitializeComponent();
            dataGridView1.DataSource = car_list;
            comboBox1.Items.AddRange(["id", "Metal", "Age", "Break"]);
        }

        public int count_car = 1;

        private void Button1_Click(object sender, EventArgs e)
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
            count_car += 1;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            string chouse = comboBox1.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White; // сброс цвета

                if (searchValue == row.Cells[$"{chouse}"].Value.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.Tan;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        async Task SaveCarToXml(BindingList<Car> car, string filePath)
        {
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Car>));
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    await Task.Run(() => serializer.Serialize(writer, car));
                }
            }
        }

        async void grid2xml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                 await SaveCarToXml(car_list, saveDialog.FileName);
            }
        }
         async Task <BindingList<Car>> LoadCarFromXml(string filePath)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Car>));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return await Task.Run(() => (BindingList<Car>)serializer.Deserialize(reader));
            }
        }

         async void xml2grid_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                BindingList<Car> loadedCar = await LoadCarFromXml(openDialog.FileName);
                dataGridView1.DataSource = loadedCar;
            }

        }

        private void clearShearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool Break = inputBreak.Checked;

            Car car = new Car
            {
                id = count_car,
                Model = inputMetal.Text,
                Metal = inputMetal.Text,
                Age = int.Parse(inputAge.Text),
                Break = Break,
            };
            car_list.Add(car);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
