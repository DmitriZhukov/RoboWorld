namespace RoboWorld
{
    public interface IRobot
    {
        public bool Lost { get; set; }
        public long Id { get; set; }

        // no public setter only use Move to change position
        public Location Loc { get;}

        // callback to tracker
        public IRobotTracker RobotTracker { set; get; }

        // dont care about the result so it is void
        void Move(Move move);

        void Move(Command command);
    }
}
