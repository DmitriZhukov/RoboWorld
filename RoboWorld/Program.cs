using System;

namespace RoboWorld
{

    class Program
    {

        protected static string _sampleInput =
@"5 3
1 1 E
RFRFRFRF
3 2 N
FRRFLLFFRRFLL
0 3 W
LLFFFLFLFL
";

        static void Main(string[] args)
        {

            // use IOC to create stuff
            // Create Coordinator instance here
            // and it will run the robots

            Console.WriteLine("Robot simulator");
            Console.WriteLine("Input:" + Environment.NewLine);

            Console.WriteLine(_sampleInput);

            Console.WriteLine("Output:" + Environment.NewLine);
            var coordinator = new Simulator();

            coordinator.Run(_sampleInput);

        }
    }
}
