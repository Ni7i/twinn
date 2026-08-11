using Twinn.Web.Models;

namespace Twinn.Web.Data;

public static class BroCatalog
{
    public static readonly string[] Interests =
    [
        "Gaming", "Fitness", "Fußball", "Basketball", "Motorrad",
        "Reisen", "Kochen", "Filme & Serien", "Musik", "Wandern",
        "Poker", "Grillen", "Festivals", "Autos", "Tech"
    ];

    public static readonly IReadOnlyList<BroProfile> All =
    [
        new("b01", "Jonas", 27, "🧢", "Bringt immer den Grill mit.",
            ["Grillen", "Fußball", "Gaming", "Bier"], "@jonas_grillt"),

        new("b02", "Marco", 24, "🏀", "Streetball am Sonntag, kein Ausreden.",
            ["Basketball", "Fitness", "Musik", "Sneaker"], "marco.hoop"),

        new("b03", "Dennis", 30, "🏍️", "Motorrad, Currywurst, fertig.",
            ["Motorrad", "Autos", "Grillen", "Reisen"], "d.dennis_ride"),

        new("b04", "Kevin", 22, "🎮", "Rank pushen bis 4 Uhr morgens.",
            ["Gaming", "Tech", "Filme & Serien", "Pizza"], "kev_pushes"),

        new("b05", "Timo", 29, "⛰️", "Jedes Wochenende ein neuer Gipfel.",
            ["Wandern", "Reisen", "Fitness", "Fotografie"], "timo.hoch"),

        new("b06", "Alex", 26, "🎧", "Festival-Kalender ist voller als der Terminkalender.",
            ["Festivals", "Musik", "Reisen", "Gaming"], "alex_beats"),

        new("b07", "Niklas", 31, "🃏", "Pokerabend Freitag, Verlierer zahlt Pizza.",
            ["Poker", "Fußball", "Bier", "Grillen"], "nik.allin"),

        new("b08", "Sami", 25, "🚗", "Schraubt lieber am Auto als am Handy.",
            ["Autos", "Tech", "Motorrad", "Gaming"], "sami_boxer"),

        new("b09", "Luca", 23, "⚽", "Sonntagsliga-Stürmer, trifft öfter die Bar.",
            ["Fußball", "Fitness", "Grillen", "Musik"], "luca10"),

        new("b10", "Fabian", 28, "🍳", "Kocht besser als er kickt.",
            ["Kochen", "Filme & Serien", "Wandern", "Reisen"], "fabi_kocht"),

        new("b11", "Robin", 24, "🏋️", "Leg day ist heilig.",
            ["Fitness", "Gaming", "Musik", "Basketball"], "robin.lifts"),

        new("b12", "Elias", 32, "🎬", "Kennt jedes Zitat aus jedem Tarantino-Film.",
            ["Filme & Serien", "Poker", "Bier", "Tech"], "elias_cuts"),

        new("b13", "Yusuf", 27, "🌍", "Immer ein Ticket zu billig gebucht.",
            ["Reisen", "Festivals", "Fotografie", "Musik"], "yusuf.roams"),

        new("b14", "Ben", 21, "🖥️", "Baut PCs zum Spaß, nicht zum Geld verdienen.",
            ["Tech", "Gaming", "Filme & Serien", "Autos"], "ben_builds"),
    ];
}
