using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
                    .WithDataVolume()
                    .WithPgAdmin(pgAdmin =>
                    {
                        pgAdmin.WithHostPort(5050);
                    });

var database = postgres.AddDatabase("GameStore");

builder.AddProject<GameStore_Api>("gamestore-api")
        .WithReference(database);

builder.Build().Run();
