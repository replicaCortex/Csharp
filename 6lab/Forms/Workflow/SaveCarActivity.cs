using dll;
using System.Activities;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace Forms.Workflow
{
    public sealed class SaveCarActivity : CodeActivity
    {
        public InArgument<Car> Car2Save { get; set; }
        public InArgument<string> FilePath { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            Car car = context.GetValue(Car2Save);
            string filePath = context.GetValue(FilePath);

            XmlSerializer serializer = new XmlSerializer(typeof(Car));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, car);
            }
            MessageBox.Show("Test SAVE");
        }


    }
}