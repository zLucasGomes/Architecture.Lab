using DDD.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DDD.Domain.Entities;

public class Anime
{
    [Required]
    public int Id { get; set; }

    [StringLength(255)]
    public string Title { get; set; } = "";

    [StringLength(255)]
    public EStatus Status { get; set; }

    [StringLength(255)]
    public EMediaType MediaType { get; set; }

    public DateOnly StartDate { get; set; }

    public float Mean { get; set; }

    [StringLength(255)]
    public ESource Source { get; set; }

    public int Popularity { get; set; }

    public int Rank { get; set; }

    [StringLength(255)]
    public ERating Rating { get; set; }

    [StringLength(255)]
    public string StartSeasonYear { get; set; } = "";

    [StringLength(255)]
    public ESeason StartSeason { get; set; }

    [StringLength(255)]
    public string Nsfw { get; set; } = "";
}
