using Microsoft.EntityFrameworkCore;
using RegistrarClientesDAL.Interfaces;
using RegistrarClientesDAL;
using RegistrarClientesBL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure el DbContext con la cadena de conexión
builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar la interfaz y la implementación de la DAL y BL
builder.Services.AddScoped<ICliente, ClienteDAL>(); 
builder.Services.AddScoped<ClienteBL>();  // Registrar la BL (aqui debo de agregar toda la interfaz de cliente, e interfaz de cliente)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cliente}/{action=Index}/{id?}");

app.Run();
