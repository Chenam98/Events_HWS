namespace Events_HWS
{
    public class BadShipExplodedEventArgs
    {
        public int ShipsExploded { get; set; }
        public int CurrentEnemyShipsNumber { get; set; }

        public BadShipExplodedEventArgs(int currentEnemyShipsNumber, int shipsExploded)
        {
            ShipsExploded = shipsExploded;
            CurrentEnemyShipsNumber = currentEnemyShipsNumber;
        }
    }
}