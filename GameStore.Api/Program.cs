using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.AddNpgsqlDbContext<GameStoreContext>("GameStore");

builder.AddRedisDistributedCache("redis");

var app = builder.Build();

app.MapDefaultEndpoints();
app.MapGamesEndpoints();
app.MapGenresEndpoints();

await app.MigrateDbAsync();

app.Run();
