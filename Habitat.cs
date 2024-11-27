using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAnInsect_wClassesDemo_FA2022
{
    //set access modifer to public
    public class Habitat
    {
        //add vars
        public string habitatName;
        public double temperature;

        //create a method to change temperature
        public void ChangeTemperature(int _tempChangeValue)
        { 
            this.temperature = this.temperature + _tempChangeValue;
        }

        //create a method to display habitat information
        public void HabitatInfo()
        {
            Console.WriteLine($"The {this.habitatName} has a current temperature of {this.temperature} ºF.");
        }

        //create a constructor for the habitat with default values
        public Habitat()
        {
            this.habitatName = "Terrarium";
            this.temperature = 65;
        }
    }
}
