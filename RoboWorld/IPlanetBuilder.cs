namespace RoboWorld
{

    // this interface is used to implement simple Builder design pattern
    public interface IPlanetBuilder
    {
        bool Build(string name, int width, int length);
    }
}
