# Game Save System 🎮

A simple game save/load system in C# using JSON serialization.

> 🇹🇷 JSON serileştirme kullanan basit bir oyun kaydetme/yükleme sistemi (C#).

---

## What does it do? / Ne yapar?

It saves a game's state (player name, health, score) to JSON, and loads it back.
Just like saving and loading a video game.

> 🇹🇷 Bir oyunun durumunu (oyuncu adı, can, skor) JSON'a kaydeder ve geri yükler.
> Tıpkı bir video oyununu kaydedip yüklemek gibi.

---

## How does it work? / Nasıl çalışır?

Two operations:

> 🇹🇷 İki işlem:

```csharp
var manager = new GameSaveManager();
var state = new GameState { PlayerName = "Meryem", Health = 100, Score = 500 };

string json = manager.Save(state);       // Serialize: object -> JSON (save)
GameState? loaded = manager.Load(json);  // Deserialize: JSON -> object (load)
```

- **Save** = Serialize = object to JSON (saving the game)
- **Load** = Deserialize = JSON to object (loading the game)

> 🇹🇷
> - **Save (Kaydet)** = Serialize = nesne → JSON (oyunu kaydetmek)
> - **Load (Yükle)** = Deserialize = JSON → nesne (oyunu yüklemek)

---

## What did I use? / Ne kullandım?

- **C# / .NET 9**
- **System.Text.Json** — JsonSerializer.Serialize / Deserialize
- **NUnit** — for tests / testler için

---

## Tests / Testler

The test saves a game state, loads it back, and checks the data is the same.

> 🇹🇷 Test bir oyun durumunu kaydeder, geri yükler ve verinin aynı olduğunu kontrol eder.

```bash
dotnet test
```

---

## What did I learn? / Ne öğrendim?

- **Serialization** = converting an object into a storable form (JSON). Like putting food in a container to store it.
  > 🇹🇷 **Serileştirme** = nesneyi saklanabilir bir forma (JSON) çevirmek. Yemeği saklamak için kaba koymak gibi.

- **Deserialization** = converting the stored JSON back into an object. Like taking the food back out.
  > 🇹🇷 **Geri serileştirme** = saklanmış JSON'u tekrar nesneye çevirmek. Yemeği kaptan geri çıkarmak gibi.

- **Save = Serialize, Load = Deserialize** — they are opposite directions.
  > 🇹🇷 **Kaydet = Serialize, Yükle = Deserialize** — birbirinin tersi yönler.
