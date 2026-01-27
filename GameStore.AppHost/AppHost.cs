var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
                    .WithDataVolume()
                    .WithPgAdmin(pgAdmin =>
                    {
                        pgAdmin.WithHostPort(5050);
                    });

postgres.AddDatabase("GameStore");

builder.Build().Run();
