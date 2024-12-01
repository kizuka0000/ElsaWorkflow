using Elsa.Extensions;
using Elsa.Workflows;
using Elsa.Workflows.Activities;
using Elsa.Workflows.Models;
using Elsa.Workflows.Attributes;
using System.ComponentModel;
using Elsa.Workflows.Expressions;

namespace ElsaStudioBlazorServer.Workflows.Activities
{
    public class Sum : CodeActivity
    {
        public Input<int> A { get; set; } = default!;
        public Input<int> B { get; set; } = default!;
        public Output<int> Result { get; set; } = default!;

        protected override async ValueTask ExecuteAsync(ActivityExecutionContext context)
        {
            int var1 = A.Get(context);
            int var2 = B.Get(context);
            Console.WriteLine("var1 " + var1);
            Console.WriteLine("var2 " + var2);

            var sum = var1 + var2;
            Console.WriteLine("The Sum is " + sum);
            Result.Set(context, sum);
        }
    }
}
