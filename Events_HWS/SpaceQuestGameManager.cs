using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HWS
{
    public class SpaceQuestGameManager
    {
        //Fields
        private int goodSpaceShipHitPoint;
        private int shipXLocation;
        private int shipYLocation;
        private int numberOfBadShips;
        private int currentLevel;

        public event EventHandler<PointEventArgs> GoodSpaceShipHPChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipLocationChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipDestroyed;
        public event EventHandler<BadShipExplodedEventArgs> BadShipExploded;
        public event EventHandler<LevelEventArgs> LevelUpReached;

        //Ctor

        public SpaceQuestGameManager(int goodSpaceShipHitPoint, int shipXLocation, int shipYLocation, int numberOfBadShips)
        {
            this.goodSpaceShipHitPoint = goodSpaceShipHitPoint;
            this.shipXLocation = shipXLocation;
            this.shipYLocation = shipYLocation;
            this.numberOfBadShips = numberOfBadShips;
        }

        //Methods

        public void MoveGoodSpaceShip(int x, int y)
        {
            shipXLocation = x;
            shipXLocation = y;
            OnGoodSpaceShipLocationChanged(x, y);
        }

        public void GoodSpaceShipGotDamaged(int damage)
        {
            goodSpaceShipHitPoint -= damage;

            if (goodSpaceShipHitPoint <= 0)
            {
                OnGoodSpaceShipExploded();
            }
            else
            {
                OnGoodSpaceShipHpChanged(damage);

                Console.WriteLine("your SpaceShip got DAMAGED!");

                Console.WriteLine($"Damage Given: {damage}");
            }
        }

        public void GoodSpaceShipGotExtraHP(int extraHP)
        {
            goodSpaceShipHitPoint += extraHP;
            Console.WriteLine($"You got extra hp: {extraHP} HP. ");
            OnGoodSpaceShipHpChanged(extraHP);
        }

        public void BadShipsDestroyed(int numberOfBadShipsDestroyd)
        {
            numberOfBadShips -= numberOfBadShipsDestroyd;
            if (numberOfBadShips <= 0)
            {
                OnBadShipExploded(numberOfBadShipsDestroyd);
                ++currentLevel;
                OnLevelUpReached();
            }
        }


        //--------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------


        private void OnGoodSpaceShipHpChanged(int hp)
        {
            GoodSpaceShipHPChanged?.Invoke(this, new PointEventArgs(hp));
        }
        private void OnGoodSpaceShipLocationChanged(int x, int y)
        {
            GoodSpaceShipLocationChanged?.Invoke(this, new LocationEventArgs(x, y));
        }
        private void OnGoodSpaceShipDamaged(int hp)
        {
            GoodSpaceShipHPChanged?.Invoke(this, new PointEventArgs(hp));
        }
        private void OnGoodSpaceShipExploded()
        {
            GoodSpaceShipDestroyed?.Invoke(this, new LocationEventArgs(shipXLocation, shipYLocation));
        }
        private void OnBadShipExploded(int badShipsExploded)
        {
            BadShipExploded?.Invoke(this, new BadShipExplodedEventArgs(numberOfBadShips, badShipsExploded));
        }
        private void OnLevelUpReached()
        {
            LevelUpReached?.Invoke(this, new LevelEventArgs(currentLevel));
        }

    }
}
