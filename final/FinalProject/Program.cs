using System;

class Program
{

    static void Main(string[] args)
    {

        SolarSystem[] systems = {null, null, null, null, null, null, null, null}; //Only used for inis
        bool on = true;
        int choice;
        Console.WriteLine("Welcome to the galaxy project! ");
        Console.Write("What is the name of your galaxy? ");
        string galaxyName = Console.ReadLine();
        Console.WriteLine("Astronomers believe that almost every galaxy has a black hole at its center. What is the name of the black hole at the center of this galaxy? ");
        string blackHoleName = Console.ReadLine();
        SupermassiveBlackHole blackHole = new SupermassiveBlackHole(blackHoleName);
        Galaxy galaxy = new Galaxy(galaxyName, systems, blackHole);

        Console.WriteLine("You should probably start by adding a new solar system to your galaxy. ");
        
        while(on == true){
            Console.Write("Select and Option:\n   1. Create a new solar System\n   2. Add body to existing system.\nYour Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            
            if(choice == 0){
                on = false;
            }
            if(choice == 1){
                Console.Write("What is the name of your new solar system? ");
                string nameOfSystem = Console.ReadLine();

                int typeOfStar;
                Console.Write("What is the name of your star? ");
                string name = Console.ReadLine();
                Console.Write("What is the mass of your star in solar mass? Note that the sun is 1 solar mass. ");
                float mass = float.Parse(Console.ReadLine());
                if(mass >= 8){
                    Console.WriteLine($"Your star will be a giant star, named {name}. For simplicities sake, all giant stars will become nuetron stars, instead of black holes when they die.");
                    typeOfStar = 1;
                }
                else{
                     Console.WriteLine($"Your star will be an average star, named {name}.");
                    typeOfStar = 0;
                }
                Star star = new Star(name, mass, 0, 0, typeOfStar);
                SolarSystem system = new SolarSystem(nameOfSystem, star);
                galaxy.setSystems(system);

                Console.WriteLine("Now that you have a solar system created, you should add some bodies to orbit its star. ");
            }
            else if (choice == 2){
                foreach(SolarSystem _system in systems){
                    int i = 0;
                    if(_system != null){
                        Console.WriteLine($"{i}. {_system.getName()}");
                        i++;
                    }
                }
                Console.Write("Which system would you like to add a body to? ");
                string systemChoice = Console.ReadLine();
                
            }
        }

    }
}