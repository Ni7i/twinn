# Twinn

Finde deine zwei Bros. Name eingeben, Interessen anhaken, durchswipen — wie Tinder, nur für Kumpels.

## Stack

- .NET 8, ASP.NET Core Blazor Server (C#, interactive server rendering)
- Kein externes UI-Framework — eigenes, handgeschriebenes CSS (neobrutalistischer Look: dicke Borders, harte Schatten, kein Gradient-Kitsch)

## Wie es funktioniert

1. **Onboarding** — Name eingeben, Interessen aus einer Chip-Liste auswählen.
2. **Swipe-Deck** — ein Stapel Bro-Profile, sortiert nach gemeinsamen Interessen (mit etwas Zufall gemischt). ✕ zum Skippen, 🤝 zum Annehmen.
3. **Match** — sobald zwei Bros angenommen wurden, gibt's den Match-Screen mit Kontakt-Handle.

Die Matching-Logik steckt in [`MatchEngine`](src/Twinn.Web/Services/MatchEngine.cs), die Profile in [`BroCatalog`](src/Twinn.Web/Data/BroCatalog.cs).

## Lokal starten

```bash
cd src/Twinn.Web
dotnet run
```

Dann im Browser: `http://localhost:5289` (Port steht in der Konsolenausgabe).

## Projektstruktur

```
src/Twinn.Web/
  Components/Pages/Home.razor   # gesamte App als Ein-Seiten-Step-Machine
  Data/BroCatalog.cs            # Interessen-Tags + Bro-Profile
  Models/BroProfile.cs          # Domain-Model
  Services/MatchEngine.cs       # Matching/Scoring-Logik
  wwwroot/app.css               # eigenes Design
```
