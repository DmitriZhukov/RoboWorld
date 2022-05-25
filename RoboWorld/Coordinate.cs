using System;

namespace RoboWorld
{
    // we use struct for maximum performance 
    // however this is value semantics
    // making struct immutable
    // general rule of thumb is to avoid structs
    // but I wanted to experiment

    /*
     Implement IEquatable for great perfomance for collection
     https://stackoverflow.com/questions/2476793/when-to-use-iequatablet-and-why
     */

    public struct Coordinate : IEquatable<Coordinate>
    {
        public readonly int X { get; }

        public readonly int Y { get; }

        public Coordinate(int x, int y){X = x; Y = y;}

        public Coordinate Offset(int x, int y)
        {
            return new Coordinate(X + x, Y + y);
        }

        public override bool Equals(object obj)
        {
            return obj is Coordinate coordinate && Equals(coordinate);
        }

        public bool Equals(Coordinate other)
        {
            return X == other.X &&
                   Y == other.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
