
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add services to the container.
var assembly = Assembly.GetExecutingAssembly();
builder.Services.RegisterServicesWithAttributes(assembly);

// Add auto mapper
builder.Services.AddAutoMapper(assembly);

// Add Errors Defined
ErrorCode.InitErrorDefine();

//Mysql
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AnpDevContext>(options =>
options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PageOnline}/{action=Home}/{id?}")
    .WithStaticAssets();


app.Run();
