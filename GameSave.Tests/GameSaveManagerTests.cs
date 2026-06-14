using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameSave.Tests
{
    [TestFixture]
    public class GameSaveManagerTests
    {
        [Test]
        public void Save_ThenLoad_ReturnsSameData()
        {
            // Arrange - hazırlık
            var manager = new GameSaveManager();
            var original = new GameState { PlayerName = "Meryem", Health = 100, Score = 500 };

            // Act - çalıştır
            string json = manager.Save(original);
            GameState? loaded = manager.Load(json);

            // Assert - doğrula
            Assert.That(loaded, Is.Not.Null);
            Assert.That(loaded!.PlayerName, Is.EqualTo("Meryem"));
            Assert.That(loaded.Health, Is.EqualTo(100));
            Assert.That(loaded.Score, Is.EqualTo(500));
        }
    }
}
