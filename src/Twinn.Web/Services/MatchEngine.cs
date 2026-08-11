using Twinn.Web.Models;

namespace Twinn.Web.Services;

public sealed class MatchEngine
{
    private readonly Random _random = new();

    public List<BroProfile> BuildDeck(string userName, IReadOnlyCollection<string> userInterests, IReadOnlyList<BroProfile> pool)
    {
        return pool
            .Select(bro => (bro, score: SharedInterestCount(bro, userInterests) + _random.NextDouble()))
            .OrderByDescending(x => x.score)
            .Select(x => x.bro)
            .ToList();
    }

    public int SharedInterestCount(BroProfile bro, IReadOnlyCollection<string> userInterests) =>
        bro.Interests.Count(userInterests.Contains);
}
