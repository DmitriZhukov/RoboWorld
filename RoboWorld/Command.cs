using System.Collections.Generic;

namespace RoboWorld
{
    // Command is sequence of moves for given robot
    public class Command
    {

        private List<Move> _moves = new List<Move>();
        public long ID { set; get; }

        public List<Move> Moves { get => _moves; }
    }
}
