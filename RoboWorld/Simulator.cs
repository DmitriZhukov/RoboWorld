using System;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace RoboWorld
{
    // this is the main class that runs the show
    
    /*
     We can run robots in Serial mode one after another
      or in parallel mode symultaneously
    
    Default is Serial
     */
    public class Simulator
    {
  

        // no exception handling
        public void Run(string commands)
        {

            RobotTracker tracker = null;

            var lines = commands.Split(new string[] { "\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);

            var iterator = lines.Cast<String>().GetEnumerator();

            if (iterator.MoveNext())
            {
                var world = iterator.Current.Split(" ", StringSplitOptions.None);               
                tracker = new RobotTracker(new Planet(Int32.Parse(world[0]), Int32.Parse(world[1])));
            }

            while(iterator.MoveNext())
            {               
                IRobot robot = new Wally(ParseLocation(iterator.Current)) { RobotTracker = tracker};

                if(iterator.MoveNext())
                {
                    var command = Command.Parse(iterator.Current);
                    robot.Move(command);

                    Console.WriteLine(robot);
                }
            }
        }

        protected Location ParseLocation(string text)
        {
            var coords = text.Split(' ');

            return new Location() { Pos = new Coordinate(Int32.Parse(coords[0]), Int32.Parse(coords[1])), Rotation = (Wind)coords[2][0]};
        }
    }
}
