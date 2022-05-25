using System;

namespace RoboWorld
{

    public interface IProcessor
    {
        void Move(IRobot robot, Move move);
    }

    public class PlanetBuilder
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

            // use IOC to create stuff
            // Create Coordinator instance here
            // and it will run the robots
            Console.WriteLine("Hello Robot World!");
        }
    }
}
