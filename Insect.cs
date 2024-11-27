using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAnInsect_wClassesDemo_FA2022
{
    //set access modifier to public
    public class Insect
    {
        //add the variables
        public string name;
        public string species;
        public string color;
        public bool hasWings;
        public int energy;

        //add a method to Eat
        public void Eat(int _foodInput)
        {
            Console.WriteLine($"{this.name} has just eaten a meal.");
            this.energy = _foodInput + this.energy;
        }

        //add a method to fly
        //this will use energy
        public void Fly()
        {
            if (hasWings)
            {
                Console.WriteLine($"{this.name} the {this.species} has flown around its habitat and burned some energy. ");

                //energy level reduced by a value of 1
                this.energy = --energy;
            }

            else
            {
                Console.WriteLine($"Sadly {this.name} the {this.species} cannot fly.");
            }

            


        }

        //add an About method
        public void About()
        {
            //this methos displays the energy level of the insect
            Console.WriteLine($"{this.name} the {this.species} has {this.energy} energy remaining.");
        }

        //create an overloaded constructor for the insect class
        //that takes three parameters as input
        public Insect(string _name, string _species, string _color, bool _hasWings)
        { 
            //marry the input parameters to the local vars
            this.name = _name; 
            this.species = _species; 
            this.color = _color;
            this.hasWings = _hasWings;  

            //set default value for energy
            this.energy = 2;
        }
    }
}
