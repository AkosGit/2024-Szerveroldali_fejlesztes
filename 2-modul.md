- ASP.NET CORE EMPTY
- wwwroot folder
	- "LaunchUrl": "index.html" in launch
- program.cs routes
```csharp
MapGet("/", async t => {
 t.Request
 t.Response
})
```
## MVC
- view: Views/X/.cshtml
- controllers: Controllers
- launchURl: "controller/method"
- Controller name scheme: valamiController
- Program .cs
```
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");


app.Run();

```
- View
```cshtml
@model 
@if()
@: h1 @Model[0]
```
- ViewModels
- Models
	- [Requred] annotation validation


