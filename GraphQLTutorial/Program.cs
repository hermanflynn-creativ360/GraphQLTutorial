using GraphQL.Server;
using GraphQL.Types;
using GraphQLTutorial.Interfaces;
using GraphQLTutorial.Query;
using GraphQLTutorial.Schema;
using GraphQLTutorial.Services;
using GraphQLTutorial.Type;
using GraphiQl;
using GraphQLTutorial.Mutation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<IProject, ProductService>();
builder.Services.AddSingleton<ProductType>();
builder.Services.AddSingleton<ProductQuery>();
builder.Services.AddSingleton<ProductMutation>();
builder.Services.AddSingleton<ISchema, ProductSchema>();

builder.Services.AddGraphQL(options => 
{
    options.EnableMetrics = false;
}).AddSystemTextJson();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.UseStaticFiles();

app.MapRazorPages();

app.Run();
