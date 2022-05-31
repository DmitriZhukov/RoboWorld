using System.Collections.Generic;

namespace RoboWorld
{
    // Command is sequence of moves for given robot
    public class Command
    {
        private List<Move> _moves = new List<Move>();
        public long ID { set; get; }

        public List<Move> Moves { get => _moves; }

        public static Command Parse(string moves)
        {
            var command = new Command();

            foreach(var letter in moves)
            {
                // not really good and safe 
                var move = (Move)letter;
                command._moves.Add(move);
            }


            return command;
        }
    }
}
