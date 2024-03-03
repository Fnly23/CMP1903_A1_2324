using System;
using System.Collections.Generic;
using System.Linq;
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
        public int sum_of_dice;
        
        public Game() { 
        
        Die3 = new Die();
        Die2 = new Die();
        Die1 = new Die();

        }   
        
        
        public int RollingGame() 
        {
        
            //
        Console.WriteLine("Press 'Enter' to roll the dice now... ");
        Console.ReadKey();
            //
            sum_of_dice += Die1.RollTheDice(); Die2.RollTheDice(); Die3.RollTheDice();
            Console.WriteLine("The dice you roll were: ");
            Console.WriteLine(Die1.DiceCurrentValue);
            Console.WriteLine(Die2.DiceCurrentValue);
            Console.WriteLine(Die3.DiceCurrentValue);
            Console.WriteLine("The number of all of the dice added together is: {0} ", (sum_of_dice));
            return sum_of_dice;

        }







        //Methods

    }
}
