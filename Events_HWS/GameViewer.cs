using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HWS
{
    public class GameViewer
    {

        public void GoodSpaceShipHpChangedEventHandler(object sender, PointEventArgs PointEventArgs)
        {
            Console.WriteLine($"your HP has changed");

            Console.WriteLine($"your hp: {PointEventArgs.Points}");
        }

        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventArgs LocationEventArgs)
        {
            Console.WriteLine($"your Location has changed");

            Console.WriteLine($"your new location: X :{LocationEventArgs.x} \n Y: {LocationEventArgs.y}");
        }

        public void GoodSpaceShipDestroyedEventHandler(object sender, LocationEventArgs locationEventArgs)
        {
            Console.WriteLine($"your Spaceship DESTROYED");

            Console.WriteLine($"GAME OVER !!!");
        }

        public void BadSpaceShipExplodedEventHandler(object sender, BadShipExplodedEventArgs badShipExplodedEventArgs)
        {
            Console.WriteLine($"bad Spaceships DESTROYED");
        }
        public void LevelUpReachedEventHandler(object sender, LevelEventArgs levelEventArgs)
        {
            Console.WriteLine($" LEVEL UP ");

            Console.WriteLine($" Your level {levelEventArgs.CurrentLevel}");
        }
    }
}
