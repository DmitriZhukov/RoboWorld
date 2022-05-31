namespace RoboWorld
{

    // TODO we need to work out what to do with Rotation
    // because 360 and 720 is the same heading
    // so need to elaborate equality check 

    public enum Wind { North='N', South = 'S', West = 'W', East = 'E' }

    public struct Location
    {
        public Coordinate Pos;

        public Wind Rotation;

        public int Degrees
        {
            get
            {
                switch (Rotation)
                {
                    case Wind.North:
                        return 90;
                    case Wind.East:
                        return 0;
                    case Wind.West:
                        return 180;
                    case Wind.South:
                        return 270;
                    default:
                        return 0;
                }
            }
        }

        public static Wind Left(Wind wind)

        {
            switch(wind)
            {
                case Wind.North:
                    return Wind.West;
                case Wind.West:
                    return Wind.South;
                case Wind.South:
                    return Wind.East;
                case Wind.East:
                    return Wind.North;
            }

            return Wind.North;
        }

        public static Wind Right(Wind wind)

        {
            switch (wind)
            {
                case Wind.North:
                    return Wind.East;
                case Wind.West:
                    return Wind.North;
                case Wind.South:
                    return Wind.West;
                case Wind.East:
                    return Wind.South;
            }

            return Wind.North;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Pos.X, Pos.Y, Rotation);
        }
    }


}
