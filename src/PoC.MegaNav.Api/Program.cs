using System.Text.Json;
using PoC.MegaNav.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseCors(config =>
{
    config.AllowAnyHeader()
          .AllowAnyMethod()
          .AllowAnyOrigin();
});

app.MapGet("api/menu/admin/ao/learner", () =>
{
    var menu = new List<MenuItem>
    {
        new MenuItem
        {
            Title = "My Learning",
            Link = "#"
        },
        new MenuItem
        {
            Title = "Admin",
            Link = "#"
        },
        new MenuItem
        {
            Title = "Inbox",
            Link = "#"
        }
    };

    return menu;
});

app.MapGet("api/menu/admin/ao/learner/count/{id}", (HttpRequest request) =>
{
    var id = request.RouteValues["id"];
    return 10;
});

app.MapGet("api/menu/admin/ao/learner/manager", () =>
{
    
    var menu = new List<MenuItem>
    {
        new MenuItem
        {
            Id= 1,
            ParentId= 0,
            Title= "My Learning",
            Link= "#",
            ComponentType = "Toggle",
            
        },
        new MenuItem
        {
            Id= 2,
            ParentId= 0,
            Title= "Live Sessions",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 3,
            ParentId= 0,
            Title= "Achievements",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 4,
            ParentId= 0,
            Title= "Inbox",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 5,
            ParentId= 0,
            Title= "Others",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 6,
            ParentId= 0,
            Title= "Cristhian Jaramillo",
            Link= "#",
            ComponentType = "Dropdown",
        },
        new MenuItem
        {
            Id= 500,
            ParentId= 6,
            Title= "Sign out",
            Link= "#",
            ComponentType = "Dropdown",
        },
        new MenuItem
        {
            Id= 501,
            ParentId= 6,
            Title= "Litmos Version 1111.2233.222",
            Link= "#",
            ComponentType = "Version",
        },
        new MenuItem
        {
            Id= 100,
            ParentId= 1,
            Title= "Global library",
            Link= "#",
            Icon="Home",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 203,
            ParentId= 100,
            Title= "Test",
            Link= "/Test/Index",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 1000,
            ParentId= 203,
            Title= "Test con",
            Link= "/Test/Index",
            Icon="Dashboard",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 250,
            ParentId= 100,
            Title= "Test 2",
            Link= "/Test/Index",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 251,
            ParentId= 250,
            Title= "Test Container 2",
            Link= "/Test/Index",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 400,
            ParentId= 100,
            Title= "Test 3",
            Link= "/Test/Index",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 500,
            ParentId= 400,
            Title= "Test Container 2",
            Link= "/Test/Index",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 252,
            ParentId= 250,
            Title= "Test Container 3",
            Link= "/Test/Index",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 253,
            ParentId= 250,
            Title= "Test Count",
            Link= "/Test/Index",
            ComponentType = "Count",
        },
        new MenuItem
        {
            Id= 101,
            ParentId= 1,
            Title= "Content",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 300,
            ParentId= 101,
            Title= "Courses",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 301,
            ParentId= 101,
            Title= "Learning Paths",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 302,
            ParentId= 101,
            Title= "Brands",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 102,
            ParentId= 1,
            Title= "Permissions",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 300,
            ParentId= 102,
            Title= "Collections",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 301,
            ParentId= 102,
            Title= "Teams",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 302,
            ParentId= 102,
            Title= "Users",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 103,
            ParentId= 2,
            Title= "Login",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 300,
            ParentId= 103,
            Title= "Collections",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 301,
            ParentId= 103,
            Title= "Teams",
            Link= "#",
            ComponentType = "Toggle",
        },
        new MenuItem
        {
            Id= 302,
            ParentId= 103,
            Title= "Users",
            Link= "#",
            ComponentType = "Toggle",
        }
    };

    var navbar = new Navbar() { LogoUrl = "https://cdn6.aptoide.com/imgs/1/5/f/15ff1ac5b31a3caca15438887eeba278_icon.png?w=128", Menu = menu };

    return navbar;
});

app.MapGet("api/menu/learner", () =>
{
    var menu = new List<MenuItem>
    {
        new MenuItem
        {
            Title = "My Learning",
            Link = "#"
        },
        new MenuItem
        {
            Title = "Live Sessions",
            Link = "#"
        },
        new MenuItem
        {
            Title = "Achievements",
            Link = "#"
        },
        new MenuItem
        {
            Title = "Inbox",
            Link = "#"
        }
    };

    return menu;
});

app.Run();