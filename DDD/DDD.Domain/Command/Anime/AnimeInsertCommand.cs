using DDD.Domain.Enums;

namespace DDD.Domain.Command.Anime;

public class AnimeInsertCommand
{
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

    public bool Nsfw { get; set; }
}
