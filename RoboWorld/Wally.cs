using System;

namespace RoboWorld
{
    public class Wally : IRobot
    {

        private Location _loc;
        private long _id;

        public long Id { get => _id; set => _id = value; }

        Location IRobot.Loc => _loc;

        public IRobotTracker RobotTracker { set; get; }

        public void Move(Move move)
        {
            switch (move)
            {
                case RoboWorld.Move.Forward:
                    var offset = Offset();
                    _loc.Pos = _loc.Pos.Offset(offset.x, offset.y);
                    break;

                case RoboWorld.Move.Left:
                    _loc.Rotation -= 90;
                    break;

                case RoboWorld.Move.Right:
                    _loc.Rotation += 90;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        // using tuple syntax here not sure it is needed 
        private (int x, int y) Offset()
        {
            return new((int)Math.Cos(_loc.Rotation), (int)Math.Sin(_loc.Rotation));
        }
    }
}
