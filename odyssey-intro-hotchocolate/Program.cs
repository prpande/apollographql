using Odyssey.MusicMatcher;
using Odyssey.MusicMatcher.Types;
using SpotifyWeb;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddHttpClient<SpotifyService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .RegisterService<SpotifyService>();

builder
    .Services
    .AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder
                .WithOrigins("https://studio.apollographql.com")
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
    });

var app = builder.Build();

app.UseCors();

app.MapGraphQL();

app.Run();
