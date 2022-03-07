using Microsoft.EntityFrameworkCore;
using NSCCCourseMap.Models;
using nscccoursemap_SMcKay92.Models;
using nscccoursemap_SMcKay92.Pages;
using Microsoft.AspNetCore.Identity;
using nscccoursemap_SMcKay92.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options => {
    options.Conventions.AuthorizeFolder("/");
});

//define course map context
builder.Services.AddDbContext<NSCCCourseMapContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("CourseMapDB")));

//define identity context
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityDataContext>();builder.Services.AddDbContext<IdentityDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityDataDB")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}



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
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
