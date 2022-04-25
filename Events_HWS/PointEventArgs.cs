namespace Events_HWS
{
    public class PointEventArgs : EventArgs
    {
        public int Points { get; set; }

        public PointEventArgs(int points)
        {
            Points = points;
        }
    }
}