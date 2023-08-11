﻿namespace PoC.MegaNav.Api.Dtos;

public record MenuItem
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public string Title { get; set; }

    public string Link { get; set; }
}
