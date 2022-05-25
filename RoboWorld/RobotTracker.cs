using System.Collections.Generic;

namespace RoboWorld
{
    public interface IRobotTracker
    {
        void LocationChanged(Location loc);

    }

    public class RobotTracker : IRobotTracker 
    {
        private readonly Dictionary<long, IRobot> _tracked = new Dictionary<long, IRobot>();

        // we can use Coordinate for key because it is struct, this is why we need struct
        private readonly Dictionary<Coordinate, int> _scents = new Dictionary<Coordinate, int>();

        // TODO this class has to have a list of subscribers that do something like
        // check the position etc

        public void LocationChanged(Location loc)
        {
            // set traces
            // check fall off the edge
            // iterate throught the subscribers
        }

        void TrackRobot(IRobot robot)
        {
            // not safe it throws if element exists better use [] or check
            _tracked.Add(robot.Id, robot);

            robot.RobotTracker = this;
        }
    }
}
