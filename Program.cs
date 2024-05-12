using EditorialDeLibros.Components;
using System.IO;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Vaciar los datos del archivo loginInfo.json al iniciar la aplicaci�n
EmptyLoginInfoFile();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

void EmptyLoginInfoFile()
{
    LoginInfo emptyLoginInfo = new LoginInfo();
    string json = JsonSerializer.Serialize(emptyLoginInfo);

    File.WriteAllText("loginInfo.json", json);
}
