using DDD.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DDD.Domain.Entities;

public class Movie
{
    [Required]
    public int Id { get; set; }

    [StringLength(255)]
    public string Title { get; set; } = "";

    [StringLength(255)]
    public EGenre Genre { get; set; }

    public int AudienceScore { get; set; }

    public float Profitability { get; set; }

    public int RottenTomatoesScore { get; set; }

    public float WorldwideGross { get; set; }

    [StringLength(255)]
    public string Year { get; set; } = "";
}
