namespace Events_HWS
{
    public class LevelEventArgs
    {
        public int CurrentLevel { get; set; }

        public LevelEventArgs(int currentLevel)
        {
            CurrentLevel = currentLevel;
        }
    }

}