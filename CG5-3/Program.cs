using System;

namespace CG5_3
{
    class Program
    {
        const int WINNING_VALUE = 20;
        const int NUMBER_DIE_SIDES = 6;

        static void Main(string[] args)
        {
            //Create a dice game to see who can get to 20 first.You will roll two 6 - sided dice and add up the numbers.
            //Then the computer gets to go, and it does the same.  This process will repeat until either you or the 
            //computer wins.You should put the rolling of the dice into its own method.  Make sure your methods have
            //XML comments for IntelliSense.  Upload your program to a new repository called CG 5 - 3.
            //Upload a link to your repository here when you are finished.

            //Assign variables required.  Both the user and the computer start with a score of 0.
            int userScore = 0;
            int computerScore = 0;
            //The dieTotal is given a value or initialized later with the RollDice method.  
            int dieTotal;
            //Bool was required because the need to take turns.  Needed a return of true or false for the next turn.
            bool userTurn = true;

            //using do/while to alternate the user and computer taking turns rolling dice.
            do
            {
                //Call the method on the right and the return of the method is being set into variable on the left. 
                dieTotal = RollDice();

                //if is evaluating either true or false.  True executes the if statement, false skips the if statment.
                if (userTurn)
                {
                    Console.WriteLine("Your turn, roll the dice by pressing enter");

                    //Stops execution of program until enter is pressed.
                    Console.ReadLine();

                    Console.WriteLine("Total of your dice is: " + dieTotal);
                    //This is the same as userScore = dieTotal + userScore.  This keeps a running total of the user's die score.
                    //This adds dieTotal with userScore and sets userScore to the result.
                    userScore += dieTotal;
                }
                //this will execute when the if statement is false.
                else
                {
                    Console.WriteLine("Computer's turn.");
                    Console.WriteLine();
                    Console.WriteLine("Total of computer dice is: " + dieTotal);

                    computerScore += dieTotal;
                }
                Console.WriteLine("Your score is: " + userScore);
                Console.WriteLine("Computer score is: " + computerScore);
                Console.WriteLine();
                //Criteria for true/false on the if statement.  It flips after each turn.  It is in the do/while.
                userTurn = !userTurn;

                //If userScore is less than winning value and computerScore is less than the winning value then true - repeat the do/while loop. 
            } while (userScore < WINNING_VALUE && computerScore < WINNING_VALUE);

            if (userScore >= WINNING_VALUE)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            //Pauses execution so the console can be read.
            Console.ReadLine();

        }
        /// <summary>
        /// Adds and returns the value of 2 dice.
        /// </summary>
        /// <returns></returns>
        private static int RollDice()
        {
            //Create variable for the dice.
            int die1;
            int die2;
            //Create variable type Random so randomizer can be used.
            Random randomizer = new Random();

            die1 = randomizer.Next(1, NUMBER_DIE_SIDES + 1);
            die2 = randomizer.Next(1, NUMBER_DIE_SIDES + 1);

            //Returns value of the dice added together.
            return (die1 + die2);
        }
    }
}
