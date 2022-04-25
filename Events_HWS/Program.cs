using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Events_HWS
{
    public class Program
    {
        static void Main(string[] args)
        {
            SpaceQuestGameManager GameMaster = new(100, 64, 43, 25);
            GameViewer GameViewer = new GameViewer();

            GameMaster.GoodSpaceShipHPChanged += GameViewer.GoodSpaceShipHpChangedEventHandler;
            GameMaster.GoodSpaceShipLocationChanged += GameViewer.GoodSpaceShipLocationChangedEventHandler;
            GameMaster.GoodSpaceShipDestroyed += GameViewer.GoodSpaceShipDestroyedEventHandler;
            GameMaster.BadShipExploded += GameViewer.BadSpaceShipExplodedEventHandler;
            GameMaster.LevelUpReached += GameViewer.LevelUpReachedEventHandler;

            GameMaster.GoodSpaceShipLocationChanged += (sender, eventArgs) => Thread.Sleep(2000);
            GameMaster.LevelUpReached += (sender, eventArgs) => Thread.Sleep(2000);
            GameMaster.GoodSpaceShipHPChanged += (sender, eventArgs) => Thread.Sleep(2000);
            GameMaster.GoodSpaceShipDestroyed += (sender, eventArgs) => Thread.Sleep(2000);
            GameMaster.BadShipExploded += (sender, eventArgs) => Thread.Sleep(2000);


            GameMaster.MoveGoodSpaceShip(70, 30);

            GameMaster.GoodSpaceShipGotDamaged(72);

            GameMaster.GoodSpaceShipGotExtraHP(40);

            GameMaster.BadShipsDestroyed(25);

            GameMaster.MoveGoodSpaceShip(23, 82);

            GameMaster.GoodSpaceShipGotDamaged(100);


        }
    }

}