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
                
                new MenuItem { Id = 1, Title = "My Learning", Link = "#", ParentId = 0, ComponentType = "Toggle" },
                new MenuItem {Id = 256, Title = "Global Library1", Link = "#", ParentId = 1, ComponentType = "Toggle" },
                new MenuItem { Id = 2, Title = "Teams", Link = "#", ParentId = 0, ComponentType = "Toggle" },
                new MenuItem { Id = 3, Title = "Inbox", Link = "#", ParentId = 0, ComponentType = "Toggle" },

                new MenuItem {Id = 10, Title = "Global Library", Link = "#", ParentId = 2, ComponentType = "Toggle", Icon = "Library" },
                new MenuItem {Id = 11, Title = "People", Link = "#", ParentId = 2, ComponentType = "Toggle", Icon = "Person" },
                new MenuItem {Id = 12, Title = "Teams", Link = "#", ParentId = 2, ComponentType = "Toggle", Icon = "Teams" },
                new MenuItem {Id = 13, Title = "Reporting", Link = "#", ParentId = 2, ComponentType = "Toggle", Icon = "References" },

                new MenuItem { Id = 100, Title = "Assign Content", Link = "#", ParentId = 10, ComponentType = "Toggle" },
                new MenuItem { Id = 101, Title = "Start Content Author", Link = "#", ParentId = 10, ComponentType = "Toggle" },
                new MenuItem { Id = 102, Title = "Create New Course", Link = "#", ParentId = 10, ComponentType = "Toggle" },
                new MenuItem { Id = 103, Title = "Bulk Course Completion", Link = "#", ParentId = 10, ComponentType = "Toggle" },
                new MenuItem { Id = 104, Title = "View All Content", Link = "admin/globalsearch/GlobalSearchResultPage?ContentType=2", ParentId = 10, ComponentType = "Toggle" },

                new MenuItem { Id = 105, Title = "Add People", Link = "#", ParentId = 11, ComponentType = "Toggle" },
                new MenuItem { Id = 106, Title = "Find People", Link = "#", ParentId = 11, ComponentType = "Toggle" },
                new MenuItem { Id = 107, Title = "Bulk Import", Link = "#", ParentId = 11, ComponentType = "Toggle" },
                new MenuItem { Id = 108, Title = "Login Activity", Link = "#", ParentId = 11, ComponentType = "Toggle" },
                new MenuItem { Id = 109, Title = "Marking List", Link = "#", ParentId = 11, ComponentType = "Toggle" },

                new MenuItem { Id = 110, Title = "Team Admin Dashboard", Link = "#", ParentId = 12, ComponentType = "Toggle" },
                new MenuItem { Id = 111, Title = "Create New Team", Link = "#", ParentId = 12, ComponentType = "Toggle" },
                new MenuItem { Id = 112, Title = "Bulk Import", Link = "#", ParentId = 12, ComponentType = "Toggle" },
                new MenuItem { Id = 113, Title = "Team Tree View", Link = "#", ParentId = 12, ComponentType = "Toggle" },
                new MenuItem { Id = 114, Title = "All Teams", Link = "#", ParentId = 12, ComponentType = "Toggle" },

                new MenuItem {Id = 115, Title = "Reporting Dashboard", Link = "#", ParentId = 13, ComponentType = "Toggle" },
                new MenuItem {Id = 116, Title = "Reporting Engine", Link = "#", ParentId = 13, ComponentType = "Toggle" },
                new MenuItem {Id = 117, Title = "My Scheduled Reports", Link = "#", ParentId = 13, ComponentType = "Toggle" },
                new MenuItem {Id = 118, Title = "Compliance Quick Report", Link = "#", ParentId = 13, ComponentType = "Toggle" },

                //new MenuItem { Id = 2, Title = this.ActiveUser.FullName, Link = "#", ParentId = 0, ComponentType = "DropDown" }
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