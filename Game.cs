using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAnInsect_wClassesDemo_FA2022
{
    //set access modifier to public
    public class Game
    {
        //create vars
        string playerNameInput;
        int playerInsectIDInput;
        int playerTemperatureInput;

        Player player1;
        Habitat myHabitat;
        Food insectFood;

        //create a method to startup the game
        public void Startup()
        {
            Intro();

            InsectHabitat();

            InsectFeeding();

            InsectFlying();

            Outro();

        }

        public void Intro()
        {
            //welcome the player
            Console.WriteLine($"Welcome to Adopt-An-Insect 2022.");
            Console.WriteLine($"This application will help you adopt an insect.");
            Console.WriteLine($"\nPlease enter you name:");

            //pass the user input to the var playerinputname 
            playerNameInput = Console.ReadLine();

            //clear the console
            Console.Clear();

            //instantiate a player object
            //pass the name input var to the player constructor
            player1 = new Player(playerNameInput);

            Console.WriteLine($"{player1.playerName}, thank you for stopping by the agency.");
            Console.WriteLine($"We have several insects available for adoption today.");
            Console.WriteLine($"\nPlease select one from the list below by entering its number:");
            Console.WriteLine($"\n1)Gary the Green Mantis");
            Console.WriteLine($"\n2)Manuel the Red and Black Lady Bug or");
            Console.WriteLine($"\n3)Jie the Purple Cricket");

            //convert the user input value to an int and save
            //the value to a var
            playerInsectIDInput = Convert.ToInt16(Console.ReadLine());

            //use conditional branching to determine which values to 
            //push to the adopt method based on user input value
            if (playerInsectIDInput == 1)
            {
                player1.Adopt("Gary", "Mantis", "Green", true);
            }
            else if (playerInsectIDInput == 2)
            {
                player1.Adopt("Manuel", "Lady Bug", "Red and Black", true);
            }
            else if (playerInsectIDInput == 3)
            {
                player1.Adopt("Jie", "Cricket", "Purple", true);
            }
            else
            {
                Console.WriteLine($"\nYou have entered an invalid selection. Please enter a value between 1 - 3");
                playerInsectIDInput = Convert.ToInt16(Console.ReadLine());
                if (playerInsectIDInput == 1)
                {
                    player1.Adopt("Gary", "Mantis", "Green", true);
                }
                else if (playerInsectIDInput == 2)
                {
                    player1.Adopt("Leeloo", "Lady Bug", "Red and Black", true);
                }
                else if (playerInsectIDInput == 3)
                {
                    player1.Adopt("Jie", "Cricket", "Purple", true);
                }
            }

            Console.ReadLine();

            //clear the console
            Console.Clear();
        }

        public void InsectHabitat()
        {
            //instantiate a habitat
            myHabitat = new Habitat();

            //tell the player how to use the thermostat on the habitat
            Console.WriteLine($"{player1.adoptee.name} has a {myHabitat.habitatName} to live in. Its current temperature is {myHabitat.temperature}ºF. \n\n{player1.adoptee.name} prefers a temperature of 80ºF. \n\nPlease enter a value below for how many degrees you'd like to increase the temperature:");

            //convert user input to int and save to var
            playerTemperatureInput = Convert.ToInt16(Console.ReadLine());

            //clear the console
            Console.Clear();

            //use the changetemperature method call
            //enter the var as a parameter
            myHabitat.ChangeTemperature(playerTemperatureInput);

            //perform method call to publish current habitat info
            myHabitat.HabitatInfo();

            Console.ReadLine();

            //clear the console
            Console.Clear();
        }

        public void InsectFeeding()
        {
            //get the energy level of the insect and give it some food
            Console.WriteLine($"{player1.GetAdopteeName()} has only {player1.adoptee.energy} energy.");

            //instantiate some food
            insectFood = new Food("Yum Yums", 5);

            //feed the insect
            Console.WriteLine($"Press the enter key to feed {player1.adoptee.name} the {player1.adoptee.species}.");

            Console.ReadLine();

            //perform method call to feed the insect
            //pass the energy value of teh food as a paramter
            //this will increase teh insects energy level
            player1.adoptee.Eat(insectFood.energyValue);

            Console.ReadLine();

            //clear the console
            Console.Clear();

            //perform an about() method call to see how much energy the insect has after eating
            player1.adoptee.About();

            Console.ReadLine();

            //clear the console
            Console.Clear();
        }

        public void InsectFlying()
        {
            //lets ask our insect to fly
            Console.WriteLine($"Now that {player1.GetAdopteeName()} has eaten, lets ask them to fly.\nPress enter to have them fly.\n");

            Console.ReadLine();

            player1.adoptee.Fly();


            //perform an about() method call to see how much energy the insect has after flying
            player1.adoptee.About();

            Console.ReadLine();
        }

        public void Outro()
        {
            Console.Clear();
            
            Console.WriteLine($"{player1.playerName} thank you for visiting the agency today and adopting {player1.adoptee.name} the {player1.adoptee.color} {player1.adoptee.species}.\n\nPress enter to close the application.");

            Console.ReadLine();
        }
    }
}
