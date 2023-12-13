using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<IUserService, UserManager>();
//builder.Services.AddSingleton<IUserDal, EfUserDal>();

//builder.Services.AddSingleton<ICuisineService, CuisineManager>();
//builder.Services.AddSingleton<ICuisineDal, EfCuisineDal>();


//builder.Services.AddSingleton<IIngredientService, IngredientManager>();
//builder.Services.AddSingleton<IIngredientDal, EfIngredientDal>();

//builder.Services.AddSingleton<IRecipeService, RecipeManager>();
//builder.Services.AddSingleton<IRecipeDal, EfRecipeDal>();

//Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder=>
{
    builder.RegisterModule(new AutofacBusinessModule());
});


builder.Services.AddDbContext<EatItContext>();
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

app.Run();
