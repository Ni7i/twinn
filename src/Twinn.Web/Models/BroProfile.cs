namespace Twinn.Web.Models;

public sealed record BroProfile(
    string Id,
    string Name,
    int Age,
    string Avatar,
    string Tagline,
    string[] Interests,
    string Contact);
