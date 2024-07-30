var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "cart",
        pattern: "cart/{cartId}",
        defaults: new { controller = "Cart", action = "Index" });
    endpoints.MapControllerRoute(
     name: "signin",
     pattern: "auth/signin",
     defaults: new { controller = "Signin", action = "Index" });
    endpoints.MapControllerRoute(
      name: "signup",
      pattern: "auth/signup",
      defaults: new { controller = "Signup", action = "Index" });

});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
