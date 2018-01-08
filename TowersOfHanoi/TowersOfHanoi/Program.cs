using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDisks = 4;

            // The first/starting peg is represented by the number 1
            const int startPeg = 1;
            // The third/ending peg is represented by the number 3
            const int endPeg = 3;

            string moves = TowerOfHanoi(numberOfDisks, startPeg, endPeg);

            // Trimming the last space concatentated when moving disks.
            string movesTrimmed = moves.TrimEnd();

            // Minimum total number of disk moves required from peg 1 to get to peg 3
            int numberOfMoves = 0;

            foreach (string move in movesTrimmed.Split(" "))
            {
                numberOfMoves++;
                Console.WriteLine(move);
            }
            Console.WriteLine("Total number of Moves: " + numberOfMoves);

            Console.ReadLine();
        }

        public static string TowerOfHanoi(int numOfDisks, int startPeg, int endPeg)
        {
            // Checking if number of disks in the current peg is one
            if (numOfDisks == 1) return startPeg + "->" + endPeg + " ";

            // Calculating the helper peg everytime the start and end peg changes
            int helperPeg = 6 - startPeg - endPeg;

            var move1 = TowerOfHanoi(numOfDisks - 1, startPeg, helperPeg);
            var move2 = startPeg + "->" + endPeg + " ";
            var move3 = TowerOfHanoi(numOfDisks - 1, helperPeg, endPeg);

            // concatenating the moves required every three steps taken
            return move1 + move2 + move3;
        }
    }
}
