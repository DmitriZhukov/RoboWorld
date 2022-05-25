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

        public void RunFile(string fileName)
        {

        }
       
        public void RunConsole()
        {

        }
    }
}
