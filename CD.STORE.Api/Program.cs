using CD.STORE.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;
using System.Text;
using UoN.ExpressiveAnnotations.NetCore.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddExpressiveAnnotations();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DbContext
builder.Services.AddDbContext<StoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"))
 );

////Add Repository
//builder.Services.AddScoped<IUserRepository, UserRepository>();
Assembly.Load("CD.STORE.Repositories").GetTypes().Where(x => x.Name.EndsWith("Repository", StringComparison.Ordinal)).ToList().ForEach(s =>
{
    var repositoryInterface = s.GetInterface(("I" + s.Name), false);
    if (repositoryInterface != null && !s.Name.Contains("Base"))
        builder.Services.AddScoped(repositoryInterface, s);
});

////Add Service
//builder.Services.AddScoped<IUserService, UserService>();
Assembly.Load("CD.STORE.ApplicationService").GetTypes().Where(x => x.Name.EndsWith("Service", StringComparison.Ordinal)).ToList().ForEach(s =>
{
    var serviceInterface = s.GetInterface(("I" + s.Name), false);
    if (serviceInterface != null)
        builder.Services.AddScoped(serviceInterface, s);
});

//builder.Services.AddHttpClient();


builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "CD STORE API", Version = "v1" });
    options.DescribeAllParametersInCamelCase();
    options.EnableAnnotations();
    //options.OperationFilter<IdsrvOperationFilter>();
    //options.SchemaFilter<SwaggerExcludeFilter>();
    options.OperationFilter<SecurityRequirementsOperationFilter>();
    options.EnableAnnotations();

    // Using System.Reflection;
    //var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    //options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(x => x .AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.Run();

