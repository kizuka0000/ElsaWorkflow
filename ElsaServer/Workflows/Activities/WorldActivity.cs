using Elsa.Workflows;
using Elsa.Workflows.Activities;
using Elsa.Workflows.Models;

namespace ElsaStudioBlazorServer.Workflows.Activities
{
    public class WorldActivity : CodeActivity
    {

        public Input<string> Name2 { get; set; } = default!;

        protected override async ValueTask ExecuteAsync(ActivityExecutionContext context)
        {
            new WriteLine("World!");
        }

    }
}
