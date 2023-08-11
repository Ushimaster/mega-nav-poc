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
            ParentId= null,
            Title= "My Learning",
            Link= "#",
        },
        new MenuItem
        {
            Id= 2,
            ParentId= null,
            Title= "Live Sessions",
            Link= "#",
        },
        new MenuItem
        {
            Id= 3,
            ParentId= null,
            Title= "Achievements",
            Link= "#",
        },
        new MenuItem
        {
            Id= 4,
            ParentId= null,
            Title= "Inbox",
            Link= "#",
        },
        new MenuItem
        {
            Id= 5,
            ParentId= null,
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