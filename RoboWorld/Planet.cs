namespace RoboWorld
{
    // Population is not inherited but rather encapsulated
    public class Planet
    {
        public int Width {get;}
        public int Length { get; }

        public Planet(int width, int length) { Width = width; Length = length; }
    }
}
