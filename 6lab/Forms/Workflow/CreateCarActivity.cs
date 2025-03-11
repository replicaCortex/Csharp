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
            string model = Model.Get(context);
            string metal = Metal.Get(context);
            int age = Age.Get(context);
            bool breakStatus = Break.Get(context);

            Car car = new Car
            {
                Model = model,
                Metal = metal,
                Age = age,
                Break = breakStatus
            };

            CustomCar.Set(context, car);
        }
    }
}
