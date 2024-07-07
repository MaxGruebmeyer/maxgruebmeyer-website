using Website.Interfaces;
using Website.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IBookHandler, BookHandler>();
builder.Services.AddScoped<IProblemHandler, ProblemHandler>();
builder.Services.AddScoped<IUtilLinkHandler, UtilLinkHandler>();
builder.Services.AddScoped<IVideoHandler, VideoHandler>();

var app = builder.Build();

// TODO (GM): Create your own error page!
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
