using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Activities.Statements;
using dll;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Forms.Workflow
{
    public class CarWorkflow
    {

        public Activity WorkflowActivity { get; set; } 

        public CarWorkflow(string model, string metal, int age, bool breakStatus)
        {
            WorkflowActivity = new Sequence
            {
                Activities = {
                    new CreateCarActivity
                    {
                       Model = new InArgument<string>(model),
                        Metal = new InArgument<string>(metal),
                        Age = new InArgument<int>(age),
                        Break = new InArgument<bool>(breakStatus),
                    },
                    new WriteLine
                    {
                        Text = "Workflow step 2"
                    }
                }
            };
        }
    }
}