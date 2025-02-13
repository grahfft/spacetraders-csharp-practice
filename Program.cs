var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddSingleton<Repository>()
    .AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddType<FirstQuery>()
    .AddType<SecondQuery>()
    .AddMutationType<Mutation>();
var app = builder.Build();

app.MapGraphQL();

app.Run();