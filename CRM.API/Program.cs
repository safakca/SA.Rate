using CRM.DataAccess.Abstract;
using CRM.DataAccess.Concrete;
using CRM.DataAccess.Concrete.EntityFramework;
using CRM.Entity.Dtos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(x =>
{
    x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

// Add services to the container.
builder.Services.AddScoped<IRateDal, EfRateDal>();
builder.Services.AddScoped<IRateQNDal, EfRateQNDal>();
builder.Services.AddScoped<IRateResultDal, EfRateResultDal>();
builder.Services.AddScoped<IRateResultDetailDal, EfRateResultDetailDal>();

builder.Services.AddAutoMapper(typeof(RateResultProfile));

builder.Services.AddControllers();

builder.Services.AddDbContext<DatabaseContext>();

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

app.UseStaticFiles();
 
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
