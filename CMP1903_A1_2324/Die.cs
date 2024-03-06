using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        private Random _randomNumber;

        public int DiceCurrentValue;
        public Die(Random rng) 
        
// this generates the random number for the dice roll. it generates a random number between 1 and 6.
        {
        this._randomNumber = rng;
        DiceCurrentValue = 0;
        }
        public int RollTheDice() 
        {
        DiceCurrentValue = _randomNumber.Next(1, 7);
        return DiceCurrentValue;


        }
    }
}
