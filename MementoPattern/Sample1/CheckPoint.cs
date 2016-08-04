using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Sample1
{
    public struct CheckPoint
    {
        public int Level { get; set; }
        public int Score { get; set; }
        public DateTime CreatedDate { get; set; }

        public CheckPoint(int level, int score, DateTime createdDate)
        {
            Level = level;
            Score = score;
            CreatedDate = createdDate;
        }

        public CheckPoint(PlayerStatistics player)
        {
            Level = player.Level;
            Score = player.Score;
            CreatedDate = player.CreatedDate;
        }
    }
}
