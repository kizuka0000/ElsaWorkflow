using Elsa.Extensions;
using Elsa.Workflows;
using Elsa.Workflows.Activities;
using Elsa.Workflows.Models;
using Elsa.Workflows.Attributes;
using System.ComponentModel;
using Elsa.Workflows.Expressions;

namespace MyProject.Activities;

public class Greeter : CodeActivity
{
    public Input<string> Name { get; set; } = default!;

    protected override void Execute(ActivityExecutionContext context)
    {
        //Console.WriteLine("Hello, Greeter!");
        Console.WriteLine($"Hello, {Name.Get(context)}!");
        var name = Name.Get(context);
        var message = $"Hello, {name}!";
        context.SetResult(message);
    }
}