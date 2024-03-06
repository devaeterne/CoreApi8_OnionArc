using CoreApi8_OnionArc.Application.Features.CQRS.Handlers.AboutHandlers;
using CoreApi8_OnionArc.Application.Features.CQRS.Handlers.BannerHandlers;
using CoreApi8_OnionArc.Application.Features.CQRS.Handlers.BrandHandlers;
using CoreApi8_OnionArc.Application.Features.CQRS.Handlers.CarHandlers;
using CoreApi8_OnionArc.Application.Features.CQRS.Handlers.ContactHandlers;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Application.Services;
using CoreApi8_OnionArc.Application.Interfaces.CarInterfaces;
using CoreApi8_OnionArc.Persistence.Context;
using CoreApi8_OnionArc.Persistence.Repositories;
using CoreApi8_OnionArc.Persistence.Repositories.CarRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Repository-IRepository
builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
//AboutScoped
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
//BannerScoped
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
//BrandScoped
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
//CarScoped
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarsWithBrandQueryHandler>();
//ContactScoped
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
//ContactScoped
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

