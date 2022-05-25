using System.Collections.Generic;

namespace RoboWorld
{
    // this class encapsulated collection of robots and more
    public class Population
    {
        private long _curID = 0;

        private readonly LinkedList<IRobot> _robotList = new LinkedList<IRobot>();

        //private Dictionary<>
        public long AddRobot(string name)
        {
            // add some creation pattern here
            // can only add Wally
            var wally = new Wally();
            _robotList.AddLast(wally);

            return ++_curID;
        }
    }
}
