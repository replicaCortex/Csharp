using System;
using System.Activities;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using dll;

namespace Forms
{
    public sealed class CreateCarActivity : CodeActivity
    {
        public InArgument<int> id { get; set; }
        public InArgument<string> Model { get; set; }
        public InArgument<string> Metal { get; set; }
        public InArgument<int> Age { get; set; }
        public InArgument<bool> Break { get; set; }
        public OutArgument<Car> CustomCar { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            int ageValue = context.GetValue(Age);

            Car car = new Car
            {
                Age = ageValue
            };

            CustomCar.Set(context, car);
        }
    }
}
