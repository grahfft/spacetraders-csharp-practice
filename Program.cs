var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddType<FirstQuery>()
    .AddType<SecondQuery>();
var app = builder.Build();

app.MapGraphQL();

app.Run();