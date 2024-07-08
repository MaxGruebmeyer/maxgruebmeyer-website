using Website;
using Website.Interfaces;
using Website.Handlers;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// TODO (GM): Review the scope once you've switched to a real DB
builder.Services.AddSingleton<IBookHandler, BookHandler>();
builder.Services.AddSingleton<IProblemHandler, ProblemHandler>();
builder.Services.AddSingleton<IUtilLinkHandler, UtilLinkHandler>();
builder.Services.AddSingleton<IVideoHandler, VideoHandler>();

WebApplication app = builder.Build();

// TODO (GM): Remove this once you've moved to a real db -> Think about JSON/Protobuf Import/Export?
TestDataGenerator.InjectTestData(app.Services);

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
