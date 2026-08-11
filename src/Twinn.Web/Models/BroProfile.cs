namespace Twinn.Web.Models;

public sealed record BroProfile(
    string Id,
    string Name,
    int Age,
    string Tagline,
    string[] Interests,
    string Contact);
