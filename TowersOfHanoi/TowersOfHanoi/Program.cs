using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n -------------- Welcome to the Tower Of Hanoi Puzzle!------------");
            Console.WriteLine(" Enter a number between 1 and 8 to see the steps taken to Hanoi!");

            int numberOfDisks = int.Parse(Console.ReadLine());

            // The first/starting peg is represented by the number 1
            const int startPeg = 1;
            // The third/ending peg is represented by the number 3
            const int endPeg = 3;

            Restart:
            Console.WriteLine(" Recursively (1) or Iteratively (2)?");
            string choice = Console.ReadLine();
            if (choice != "1")
            {
                int result = TowerOfHanoiIterative(numberOfDisks, startPeg, endPeg);
                Console.WriteLine("Number of steps Iteratively: {0}", result);
            }
            else
            {
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
                Console.WriteLine("Total number of Moves Recursively: " + numberOfMoves);
            }

            Console.WriteLine("\n Type a number to play again or 'E' to exit.");
            string newInput = Console.ReadLine();
            if (newInput.ToUpper() != "E")
            {
                numberOfDisks = int.Parse(newInput);
                goto Restart;
            }
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
            string moves = move1 + move2 + move3;
            return moves;
        }

        public static int TowerOfHanoiIterative(int pegOneTotalDisks, int startPeg, int endPeg)
        {
            if (pegOneTotalDisks == 1)
            {
                Console.WriteLine(startPeg + "->" + endPeg);
                return 1;
            }
            List<int> pegTwo = new List<int>();
            List<int> pegThree = new List<int>();
            int count = 0;
            int helperPeg = 6 - startPeg - endPeg;
            for (int i = pegOneTotalDisks; i >= 1; i--)
            {
                pegTwo.Add(i);
                count++;
                Console.WriteLine(startPeg + "->" + helperPeg);
            }
            foreach (int d in pegTwo)
            {
                pegThree.Add(d);
                count++;
                Console.WriteLine(helperPeg + "->" + endPeg);
            }
            return count;
        }
    }
}
