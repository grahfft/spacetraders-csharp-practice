var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddSingleton<Repository>()
    .AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddType<FirstQuery>()
    .AddType<SecondQuery>()
    .AddMutationType(m => m.Name("Mutation"))
    .AddType<FirstMutation>()
    .AddType<SecondMutation>();
var app = builder.Build();

app.MapGraphQL();

app.Run();