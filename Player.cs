using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAnInsect_wClassesDemo_FA2022
{
    //set access modifier to public
    public class Player
    {
        //add vars
        public Insect adoptee;
        public string playerName;
        

        //create a nethod to adopt an insect
        public void Adopt(string _name, string _species, string _color, bool _hasWings)
        { 
            adoptee = new Insect(_name, _species, _color, _hasWings);

            //clear the console
            Console.Clear();

            Console.WriteLine($"Congratulations {this.playerName}!");
            Console.WriteLine($"\nYou have just adopted {adoptee.name} the {adoptee.color} {adoptee.species}.");
        }

        //create an overloaded constructor with one parameter
        //that will pass through the player provide name
        public Player(string _playerName)
        { 
            //marry the input parameter to the local var
            this.playerName = _playerName;
        }

        //create a method to return adoptee name
        public string GetAdopteeName()
        { 
            return this.adoptee.name;
        }

        //create a method to get the adoptee energy level
        public int GetAdopteeEnergyLevel()
        {
            return this.adoptee.energy;
        }
    }
}
