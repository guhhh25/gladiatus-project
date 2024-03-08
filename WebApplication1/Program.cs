using Gladiatus.Application;
using Gladiatus.Application.Mapping;
using Gladiatus.Core;
using Gladiatus.Core.Entities;
using Gladiatus.Infrastructure.Repository;
using Gladiatus.Infrastructure.Repository.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddInfrastructureLayer(configuration);
builder.Services.AddCoreLayer();
builder.Services.AddApplicationLayer();

builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();