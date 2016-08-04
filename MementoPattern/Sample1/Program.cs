using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoPattern.Sample1
{
    public static class Program
    {
        public static void Excute()
        {
            // init data
            Console.WriteLine("Init player");
            var player = new PlayerStatistics();
            player.Level = 1;
            player.Score = 100;
            player.CreatedDate = DateTime.Now;
            player.PrintStatistics();

            // create checkpoint taker to store checkpoint instance
            var taker = new CheckPointHolder();
            taker.CheckPoint = player.CreateCheckPoint(player);
            Console.WriteLine();

            Thread.Sleep(2000);

            // change data
            Console.WriteLine("Change data");
            player.Level = 2;
            player.Score = 200;
            player.CreatedDate = DateTime.Now;
            player.PrintStatistics();
            Console.WriteLine();

            // restore data
            Console.WriteLine("Restore data");
            player.RestoredCheckPoint(taker.CheckPoint);
            player.PrintStatistics();
            Console.ReadLine();
        }
    }
}
