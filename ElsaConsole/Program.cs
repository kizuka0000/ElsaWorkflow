using Elsa.Extensions;
using Elsa.Workflows.Activities;
using Elsa.Workflows.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using System.ComponentModel;
using Elsa.Workflows.Expressions;

using MyProject.Activities;

// Setup service container.
var services = new ServiceCollection();

// Add Elsa services to the container.
services.AddElsa(elsa => elsa.AddActivity<Greeter>());

// Build the service container.
var serviceProvider = services.BuildServiceProvider();

// Create a variable to store the greeting.
var greeting = new Variable<string>();

// Define a simple workflow that writes a message to the console.
var workflow = new Workflow
{
    // Add the variable to the workflow.
    Variables = { greeting },

    Root = new Sequence{
        Activities = 
        {
            new WriteLine("Hello World!"), 
            new WriteLine("Goodbye cruel world..."),
            // new Greeter{
            //     Name = new("INPUT"),
            //     // Set the variable to the output of the activity.
            //     Result = new(greeting)
            // },
        }
    }

    
};

// Resolve a workflow runner to execute the workflow.
var workflowRunner = serviceProvider.GetRequiredService<IWorkflowRunner>();

// Execute the workflow.
await workflowRunner.RunAsync(workflow);