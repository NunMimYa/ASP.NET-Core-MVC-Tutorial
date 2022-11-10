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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


/*
 * MVC appelle les classes de contrôleur et les méthodes d’action qu’elles contiennent, en fonction de l’URL entrante. 
 * La logique de routage d’URL par défaut utilisée par MVC utilise un format semblable à celui-ci pour déterminer le code à appeler :
 * /[Controller]/[ActionName]/[Parameters]
 */