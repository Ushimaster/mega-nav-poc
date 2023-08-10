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
            Title = "My Learning",
            Link = "#"
        },
        new MenuItem
        {
            Title = "Manager",
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