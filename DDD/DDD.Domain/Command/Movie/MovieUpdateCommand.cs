using DDD.Domain.Enums;

namespace DDD.Domain.Command.Movie;

public class MovieUpdateCommand
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public EGenre Genre { get; set; }

    public int AudienceScore { get; set; }

    public float Profitability { get; set; }

    public int RottenTomatoesScore { get; set; }

    public float WorldwideGross { get; set; }

    public string Year { get; set; } = "";
}
