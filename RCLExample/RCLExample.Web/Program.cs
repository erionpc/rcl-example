using RCLExample.Web.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddRazorPages();

//builder.Services.AddOptions();
//var section = builder.Configuration.GetSection("TemplateConfig");
//builder.Services.Configure<TemplateConfigCollection>(section);
var templateConfig = new TemplatesConfiguration();
builder.Configuration.Bind("TemplatesConfiguration", templateConfig);
builder.Services.AddSingleton(templateConfig);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
