using Elsa.Extensions;
using Elsa.Workflows;
using Elsa.Workflows.Activities;
using Elsa.Workflows.Models;
using Elsa.Workflows.Attributes;
using System.ComponentModel;
using Elsa.Workflows.Expressions;

namespace ElsaStudioBlazorServer.Workflows.Activities
{
    public class HelloActivity : CodeActivity
    {
        public Input<string> inputMessage { get; set; } = default!;
        public Output<string> outMessage { get; set; } = default!;

        protected override async ValueTask ExecuteAsync(ActivityExecutionContext context)
        {
            Console.WriteLine("Hello 1234");
            string finalMessage = "Goodbye " + inputMessage.Get(context);
            Console.WriteLine(finalMessage);
            
            outMessage.Set(context, "TEST_OUT");
        }
    }
}
