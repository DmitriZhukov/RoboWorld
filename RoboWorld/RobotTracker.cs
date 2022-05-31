using System.Collections.Generic;

namespace RoboWorld
{
    public interface IRobotTracker
    {
        void LocationChanged(IRobot robot, Location loc);
    }

    public class RobotTracker : IRobotTracker 
    {
        private readonly Dictionary<long, IRobot> _tracked = new Dictionary<long, IRobot>();
        private readonly Planet _planet;

        public RobotTracker(Planet planet)
        {
            _planet = planet;
        }

        // we can use Coordinate for key because it is struct, this is why we need struct
        private readonly Dictionary<Location, int> _scents = new Dictionary<Location, int>();


        public void LocationChanged(IRobot robot, Location loc)
        {
            var oldPos = robot.Loc;

            if (!InBounds(robot))
            {
                robot.Lost = true;
                _scents.TryAdd(robot.Loc, 1);
            }
        }

        void TrackRobot(IRobot robot)
        {
            // not safe it throws if element exists better use [] or check
            _tracked.Add(robot.Id, robot);
            robot.RobotTracker = this;
        }

        protected bool InBounds(IRobot robot)
        {
            return robot.Loc.Pos.X >= 0
                && robot.Loc.Pos.X <= _planet.Width
                && robot.Loc.Pos.Y >= 0
                && robot.Loc.Pos.Y <= _planet.Length;
        }
    }
}
