using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */
        public static void Test()
        {
        Game game = new Game();
        int SumOfDice = game.RollingGame();

// debug asserting which will allow to find the individual dice rolls
        Debug.Assert(game.Die1.DiceCurrentValue >= 1 && game.Die1.DiceCurrentValue <= 6, "Dice 1 is out of range");
        Debug.Assert(game.Die2.DiceCurrentValue >= 1 && game.Die2.DiceCurrentValue <= 6, "Dice 2 is out of range");
        Debug.Assert(game.Die3.DiceCurrentValue >= 1 && game.Die3.DiceCurrentValue <= 6, "Dice 3 is out of range");

// the debug asserting tool is used to find the total value and make sure it is the correct number
// it assigns the expected total to the values of the total from the game class
        int ExpectedTotal = game.Die1.DiceCurrentValue + game.Die2.DiceCurrentValue + game.Die3.DiceCurrentValue;
        Debug.Assert(SumOfDice == ExpectedTotal, $"Unexpected total: {SumOfDice}");

        Console.WriteLine("Tests passed successfully.");

        }
    }
}
