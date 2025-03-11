using dll;
using System.Activities;
using System.Activities.Statements;

namespace Forms.Workflow
{
    public class CarWorkflow
    {

        public Activity WorkflowActivity { get; set; }
        public OutArgument<Car> NewCar { get; set; }

        public CarWorkflow(string model, string metal, int age, bool breakStatus, string filePath)
        {

            Variable<Car> carVariable = new Variable<Car>
            {
                Name = "createdCar"
            };

            WorkflowActivity = new Sequence
            {
                Variables = { carVariable },
                Activities = {
                    new CreateCarActivity
                    {
                        Model = new InArgument<string>(model),
                        Metal = new InArgument<string>(metal),
                        Age = new InArgument<int>(age),
                        Break = new InArgument<bool>(breakStatus),
                        CustomCar = new OutArgument<Car>(carVariable)
                    },

                    new SaveCarActivity
                    {
                        Car2Save =  new InArgument<Car>(carVariable),
                        FilePath = new InArgument<string>(filePath)

                    }
                }
            };
        }
    }
}