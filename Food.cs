using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAnInsect_wClassesDemo_FA2022
{
    //set access modifier to public
    public class Food
    {
        //add a var for food name and energy value
        public string foodName;
        public int energyValue;

        //create a constructor with two parameters
        public Food(string _foodName, int _energyValue)
        { 
            //marry the input parameters to the local vars
            this.foodName = _foodName;
            this.energyValue = _energyValue;
        }
    }
}
