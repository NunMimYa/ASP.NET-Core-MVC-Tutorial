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
 * MVC appelle les classes de contr�leur et les m�thodes d�action qu�elles contiennent, en fonction de l�URL entrante. 
 * La logique de routage d�URL par d�faut utilis�e par MVC utilise un format semblable � celui-ci pour d�terminer le code � appeler :
 * /[Controller]/[ActionName]/[Parameters]
 */