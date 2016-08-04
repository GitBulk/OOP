using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Sample1
{
    public class PlayerStatistics
    {
        public int Level { get; set; }
        public int Score { get; set; }

        public DateTime CreatedDate { get; set; }

        public CheckPoint CreateCheckPoint(PlayerStatistics player)
        {
            //return new CheckPoint(player.Level, player.Score, player.CreatedDate);
            return new CheckPoint(player);
        }

        public void RestoredCheckPoint(CheckPoint checkpoint)
        {
            this.Level = checkpoint.Level;
            this.Score = checkpoint.Score;
            this.CreatedDate = checkpoint.CreatedDate;
        }

        public void PrintStatistics()
        {
            Console.WriteLine("Checkpoint time: " + this.CreatedDate);
            Console.WriteLine("Level: " + this.Level);
            Console.WriteLine("Score: " + this.Score);
        }
    }
}
