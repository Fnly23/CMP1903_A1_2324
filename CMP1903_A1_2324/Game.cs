using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         
         *
         *
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */
        //
       
        public Die Die1;
        public Die Die2;
        public Die Die3;
        public int SumOfDice;
        
        public Game() 
        {
// this makes sure that every dice is completely random
        Random rng = new Random();
        Die3 = new Die(rng);
        Die2 = new Die(rng);
        Die1 = new Die(rng);

        }
        public int RollingGame()
        {

// this makes sure that you can read the dice rolls 
        Console.WriteLine("Press 'Enter' to roll the dice now... ");
        Console.ReadKey();
// the following chunk is the dice being rolled and then added together into one variable
        SumOfDice += Die1.RollTheDice();
        SumOfDice += Die2.RollTheDice();
        SumOfDice += Die3.RollTheDice();
// printing out which dice is which roll.
        Console.WriteLine("The dice you roll were: ");
        Console.WriteLine(Die1.DiceCurrentValue);
        Console.WriteLine(Die2.DiceCurrentValue);
        Console.WriteLine(Die3.DiceCurrentValue);
        Console.WriteLine("The number of all of the dice added together is: {0} ", (SumOfDice));
        return SumOfDice;

        }
    }
}
