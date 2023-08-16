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
        },
        new MenuItem
        {
            Id= 2,
            ParentId= 0,
            Title= "Live Sessions",
            Link= "#",
        },
        new MenuItem
        {
            Id= 3,
            ParentId= 0,
            Title= "Achievements",
            Link= "#",
        },
        new MenuItem
        {
            Id= 4,
            ParentId= 0,
            Title= "Inbox",
            Link= "#",
        },
        new MenuItem
        {
            Id= 5,
            ParentId= 0,
            Title= "Others",
            Link= "#",
        },
        new MenuItem
        {
            Id= 100,
            ParentId= 1,
            Title= "Global library",
            Link= "#",
        },
        new MenuItem
        {
            Id= 200,
            ParentId= 100,
            Title= "Courses",
            Link= "#",
        },
        new MenuItem
        {
            Id= 201,
            ParentId= 100,
            Title= "Learning Paths",
            Link= "#",
        },
        new MenuItem
        {
            Id= 202,
            ParentId= 100,
            Title= "Brands",
            Link= "#",
        },
        new MenuItem
        {
            Id= 203,
            ParentId= 100,
            Title= "Test",
            Link= "/Test/Index",
        },
        new MenuItem
        {
            Id= 101,
            ParentId= 1,
            Title= "Content",
            Link= "#",
        },
        new MenuItem
        {
            Id= 300,
            ParentId= 101,
            Title= "Courses",
            Link= "#",
        },
        new MenuItem
        {
            Id= 301,
            ParentId= 101,
            Title= "Learning Paths",
            Link= "#",
        },
        new MenuItem
        {
            Id= 302,
            ParentId= 101,
            Title= "Brands",
            Link= "#",
        },
        new MenuItem
        {
            Id= 102,
            ParentId= 1,
            Title= "Permissions",
            Link= "#",
        },
        new MenuItem
        {
            Id= 300,
            ParentId= 102,
            Title= "Collections",
            Link= "#",
        },
        new MenuItem
        {
            Id= 301,
            ParentId= 102,
            Title= "Teams",
            Link= "#",
        },
        new MenuItem
        {
            Id= 302,
            ParentId= 102,
            Title= "Users",
            Link= "#",
        },
        new MenuItem
        {
            Id= 103,
            ParentId= 2,
            Title= "Login",
            Link= "#",
        },
        new MenuItem
        {
            Id= 300,
            ParentId= 103,
            Title= "Collections",
            Link= "#",
        },
        new MenuItem
        {
            Id= 301,
            ParentId= 103,
            Title= "Teams",
            Link= "#",
        },
        new MenuItem
        {
            Id= 302,
            ParentId= 103,
            Title= "Users",
            Link= "#",
        }
    };

    return menu;
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