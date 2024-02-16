using Projects;
using Verisoft.Codereview.DotnetAspire.ServiceDefaults;

var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddPostgresContainer(Constants.DatabaseContainer, 5432, "n3jakE&heSl0")
                .AddDatabase(Constants.DatabaseName);

var apiService = builder.AddProject<Verisoft_Codereview_DotnetAspire_ApiService>(Constants.ApiProject)
                        .WithReference(db);

builder.AddProject<Verisoft_Codereview_DotnetAspire_Web>(Constants.WebProject)
       .WithReference(apiService);

builder.Build()
       .Run();