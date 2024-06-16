var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.DB2File_ApiService>("apiservice");

builder.AddProject<Projects.DB2File_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.AddProject<Projects.DB2File_WorkService>("db2file-workservice");

builder.Build().Run();
