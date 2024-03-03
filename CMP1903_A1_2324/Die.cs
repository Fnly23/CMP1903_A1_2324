using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
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

        private Random RandomNumber;

        public int DiceCurrentValue;
        public Die(Random rng) 
        

        {
            this.RandomNumber = rng;
            DiceCurrentValue = 0;
       
        
        }

        public int RollTheDice() 
        {
            
            
            Random rng = new Random();
            
            DiceCurrentValue = RandomNumber.Next(1, 7);


           
            
            //DiceCurrentValue = rng.Next(1, 7);

        return DiceCurrentValue;


        }




        //Method
    
    
        

    }
}
