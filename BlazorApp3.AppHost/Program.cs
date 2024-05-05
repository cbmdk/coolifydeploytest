var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorApp3>("blazorapp3");

builder.Build().Run();
