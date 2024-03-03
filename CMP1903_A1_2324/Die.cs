using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        Random rng = new Random();

        public int DiceCurrentValue;
        public Die() 
        

        {
            DiceCurrentValue = 0;
       
        
        }

        public int RollTheDice() 
        {
        DiceCurrentValue = rng.Next(1, 7);

        return DiceCurrentValue;


        }




        //Method
    
    
        

    }
}
