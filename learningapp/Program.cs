var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
/*builder.Configuration
.AddJsonFile("appsettings.json")
    .AddEnvironmentVariables();*/
builder.Configuration.AddAzureAppConfiguration("Endpoint=https://applicationconfig100.azconfig.io;Id=tdpS;Secret=FOYcASVCNILdgRqEqsvDxqzzA71zAFsWdtmKyF1kNwOsKW85wVniJQQJ99BCAC1i4TkK1x3GAAABAZAC2Ktw");

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

app.MapRazorPages();

app.Run();
