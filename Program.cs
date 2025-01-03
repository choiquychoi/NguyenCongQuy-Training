using practice_C_.Areas.code;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<SessionHelper>();

builder.Services.AddHttpContextAccessor();


// Đăng ký các dịch vụ cần thiết
builder.Services.AddControllersWithViews();

// Đăng ký dịch vụ Session
builder.Services.AddSession(); // Thêm dòng này

// Đăng ký IHttpContextAccessor (nếu cần)
builder.Services.AddHttpContextAccessor();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Thêm middleware
app.UseStaticFiles();
app.UseRouting();
app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapDefaultControllerRoute();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();
