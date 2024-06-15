var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.DB2File_ApiService>("apiservice");

builder.AddProject<Projects.DB2File_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
