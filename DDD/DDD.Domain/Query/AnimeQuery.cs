using DDD.Domain.Enums;

namespace DDD.Domain.Query;

public class AnimeQuery
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public EStatus Status { get; set; }

    public EMediaType MediaType { get; set; }

    public DateOnly StartDate { get; set; }

    public float Mean { get; set; }

    public ESource Source { get; set; }

    public int Popularity { get; set; }

    public int Rank { get; set; }

    public ERating Rating { get; set; }

    public string StartSeasonYear { get; set; } = "";

    public ESeason StartSeason { get; set; }

    public string Nsfw { get; set; } = "";
}
