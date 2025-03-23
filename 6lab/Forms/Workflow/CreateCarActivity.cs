using dll;
using System.Activities;
using System.Windows;

namespace Forms
{
    public sealed class CreateCarActivity : CodeActivity
    {
        public InArgument<string> Model { get; set; }
        public InArgument<string> Metal { get; set; }
        public InArgument<int> Id { get; set; }
        public InArgument<int> Age { get; set; }
        public InArgument<bool> Break { get; set; }
        public OutArgument<Car> CustomCar { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string model = Model.Get(context);
            string metal = Metal.Get(context);
            int age = Age.Get(context);
            int id = Id.Get(context);
            bool breakStatus = Break.Get(context);

            Car car = new Car
            {
                id = id,
                Model = model,
                Metal = metal,
                Age = age,
                Break = breakStatus
            };

            CustomCar.Set(context, car);
            MessageBox.Show("Test CREATE ");
        }
    }
}
