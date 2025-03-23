using dll;
using System.Activities;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Forms.Workflow
{
    public sealed class SaveCarActivity : CodeActivity
    {
        public InArgument<Car> Car2Save { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            Car car = context.GetValue(Car2Save);
            BindingList<Car> car_list = new BindingList<Car>();
            car_list.Add(car);

            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Car>));
                using (TextWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    serializer.Serialize(writer, car_list);
                }
            }

        }


    }
}