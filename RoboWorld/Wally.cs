using System;

namespace RoboWorld
{
    public class Wally : IRobot
    {

        private Location _loc;
        private long _id;


        public long Id { get => _id; set => _id = value; }

        Location IRobot.Loc => _loc;

        public bool Lost { get; set; }

        public IRobotTracker RobotTracker { set; get; }

        public Wally(Location loc)
        {
            _loc = loc;
        }

        public void Move(Move move)
        {
            switch (move)
            {
                case RoboWorld.Move.Forward:
                    var offset = Offset();
                    _loc.Pos = _loc.Pos.Offset(offset.x, offset.y);

                    RobotTracker?.LocationChanged(this, _loc);
                    break;

                case RoboWorld.Move.Left:
                    _loc.Rotation = Location.Left(_loc.Rotation);

                    RobotTracker?.LocationChanged(this, _loc);
                    break;

                case RoboWorld.Move.Right:
                    _loc.Rotation = Location.Right(_loc.Rotation);

                    RobotTracker?.LocationChanged(this, _loc);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        public void Move(Command command)
        {
            foreach(var move in command.Moves)
            {
                Move(move);
            }
        }

        // using tuple syntax here not sure it is needed 
        private (int x, int y) Offset()
        {
            return new((int)Math.Cos(Math.PI *_loc.Degrees / 180), (int)Math.Sin(Math.PI *_loc.Degrees / 180));
        }

        public override string ToString()
        {
            return _loc.ToString() + (Lost ? " LOST" : "");
        }
    }
}
