namespace PoC.MegaNav.Api.Dtos;

public record MenuItem
{
    public MenuItem? Parent { get; set; }

    public string Title { get; set; }

    public string Link { get; set; }
}
