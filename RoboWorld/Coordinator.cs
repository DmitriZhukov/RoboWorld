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
    public class Coordinator
    {
        private readonly ILogger<Coordinator> _logger;

        private bool ParseFile(string fileName)
        {
            // TODO implement
            // build the world, populate it with robots and run the robots
            return false;
        }

        public void Run(string commands)
        {
            var lines = commands.Split(new string[] { "\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);


            var iterator = lines.Cast<String>().GetEnumerator();
            var world = iterator.Current.Split(" ", StringSplitOptions.None);

            while(iterator.MoveNext())
            {
                // get coordinates
                // var coords = 
                // get moves
            }

            var planet = new Planet(Int32.Parse(world[0]), Int32.Parse(world[1]));
        }

        protected (int x, int y) ParseCoordinates(string text)
        {
            var coords = text.Split(' ');
            return new(Int32.Parse(coords[0]), Int32.Parse(coords[1]));
        }



        public void RunFile(string fileName)
        {

        }
       
        public void RunConsole()
        {

        }
    }
}
