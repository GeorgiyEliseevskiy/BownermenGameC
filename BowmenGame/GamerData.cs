using System;
using System.Drawing;

namespace BowmenGame
{
    // Класс, представляющий данные об игроке в игре с лучниками
    public class GamerData
    {
        // Событие, вызываемое при поражении команды
        public event Action<GamerData> TeamDefeat;

        // Свойство, представляющее количество побед лучников в команде (по умолчанию 5)
        public int BowmenWinCount { get; set; } = 5;

        // Свойство, представляющее цвет команды
        public Color TeamColor { get; set; }

        // Свойство, представляющее цвет вражеской команды
        public Color EnemyColor { get; set; }

        // Приватное поле, представляющее текущее количество живых лучников в команде
        private int aliveBowmenCount = 5;

        // Метод для получения текущего количества живых лучников в команде
        public int GetAliveBowmenCount() => aliveBowmenCount;

        // Метод для увеличения количества живых лучников на 1
        public void AliveBowmenCount_Increment()
        {
            // Проверка на превышение максимального количества лучников в команде
            if (aliveBowmenCount + 1 > 5)
                throw new Exception("More than 5 bowmen in team");
            else
                aliveBowmenCount++;
        }

        // Метод для уменьшения количества живых лучников на 1
        public void AliveBowmenCount_Decrement()
        {
            // Проверка на уменьшение количества лучников меньше 0
            if (aliveBowmenCount - 1 < 0)
                throw new Exception("Less than 0 bowmen in team");
            else
                aliveBowmenCount--;

            // Проверка на поражение команды при отсутствии живых лучников
            if (aliveBowmenCount == 0)
                TeamDefeat.Invoke(this);
        }
    }
}