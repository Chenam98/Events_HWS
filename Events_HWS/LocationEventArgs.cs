namespace Events_HWS
{
    public class LocationEventArgs
    {
        public int x { get; set; }
        public int y { get; set; }

        public LocationEventArgs(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}