using System;

class Program
{

    static void Main(string[] args)
    {
        Console.Clear();
        SolarSystem[] systems = {null, null, null, null, null, null, null, null}; //Only used for inis
        bool on = true;
        int choice;
        Console.WriteLine("Welcome to the galaxy project! ");
        Console.Write("What is the name of your galaxy? ");
        string galaxyName = Console.ReadLine();
        Console.Write("Astronomers believe that almost every galaxy has a black hole at its center. \nWhat is the name of the black hole at the center of this galaxy? ");
        string blackHoleName = Console.ReadLine();
        SupermassiveBlackHole blackHole = new SupermassiveBlackHole(blackHoleName);
        Galaxy galaxy = new Galaxy(galaxyName, systems, blackHole);

        
        while(on == true){
            Console.Clear();
            int time = 0;
            if(time == 0){
                Console.WriteLine("You should start by adding a solar system, or you will get an error :( ");
                time = 1;
            }
            Console.WriteLine($"Welcome to the galaxy program for the {galaxy.getName()} galaxy."); 
            Console.Write("Select and Option:\n   0. End program.\n   1. Create a new solar System.\n   2. Add body to existing system.\n   3. Display Solar System.\n   4. Age the universe...\nYour Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            
            if(choice == 0){
                Console.Clear();
                on = false;
            }
            if(choice == 1){
                Console.Clear();
                Console.Write("What is the name of your new solar system? ");
                string nameOfSystem = Console.ReadLine();

                int typeOfStar;
                Console.Write("What is the name of your star? ");
                string name = Console.ReadLine();
                Console.Write("What is the mass of your star in solar mass? Note that the sun is 1 solar mass. ");
                float mass = float.Parse(Console.ReadLine());
                if(mass >= 8){
                    Console.WriteLine($"Your star will be a giant star, named {name}. ");
                    typeOfStar = 1;
                }
                else{
                     Console.WriteLine($"Your star will be an average star, named {name}.");
                    typeOfStar = 0;
                }
                Star star = new Star(name, mass,  0, typeOfStar);
                SolarSystem system = new SolarSystem(nameOfSystem, star);
                galaxy.setSystems(system);

                Console.WriteLine("Now that you have a solar system created, you should add some bodies to orbit its star. ");
            }
            else if (choice == 2){
                Console.Clear();
                int i = 0;
                foreach(SolarSystem _system in systems){
                    
                    if(_system != null){
                        Console.WriteLine($"{i}. {_system.getName()}");
                        i++;
                    }
                }
                
                Console.Write("Which system would you like to add a body to? ");
                int solarchoice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Which type of body would you like to add?\n   1. Planet\n   2. Asteroid \nAnswer: ");
                int bodyChoice = Convert.ToInt32(Console.ReadLine());
                if(bodyChoice == 1){
                    Console.Write("Will this be a \n   1. Terrestrial Planet\n   2. A Gas Giant?\n Answer: ");
                    string Planettype;
                    int planetChoice = Convert.ToInt32(Console.ReadLine());
                    if(planetChoice == 1){
                        Planettype = "Terrestrial";
                    }
                    else{
                        Planettype = "Gas";
                    }
                    Console.Write("What will the name of this planet be? ");
                    string name = Console.ReadLine();
                    Console.Write("What is the density of the atmosphere of this planet? (In Kg/m^3, Earth is around 1)");
                    float density = float.Parse(Console.ReadLine());
                    int mass = 1;
                    Planet planet = new Planet(name, mass, Planettype, density);
                    Star toAddStar = systems[solarchoice].getStar();
                    toAddStar.appendPlanets(planet);
                }
                else if (bodyChoice == 2){
                    Console.Write("What will the name of this asteroid be? ");
                    string Asname = Console.ReadLine();
                    Console.Write("Is this a \n   1. Comet  \n   0. Asteroid?\nAnswer: ");
                    int comet = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Is this comet in orbit? \n   1. Yes \n   0. No \nAnswer: ");
                    int orbit = Convert.ToInt32(Console.ReadLine());
                    
                    Asteroid asteroid = new Asteroid(Asname, 1, comet, orbit);
                    Star toAddStar = systems[solarchoice].getStar();
                    toAddStar.appendAsteroids(asteroid);
                }
                
            }
            else if (choice == 3){
                string healthy = @"o               .        ___---___                    .
       .              .--\        --.     .     .         .
                    ./.;_.\     __/~ \.
                   /;  / `-'  __\    . \
 .        .       / ,--'     / .   .;   \        |
                 | .|       /       __   |      -O-       .
                |__/    __ |  . ;   \ | . |      |
                |      /  \\_    . ;| \___|
   .    o       |      \  .~\\___,--'     |           .
                 |     | . ; ~~~~\_    __|
    |             \    \   .  .  ; \  /_/   .
   -O-        .    \   /         . |  ~/                  .
    |    .          ~\ \   .      /  /~          o
  .                   ~--___ ; ___--~
                 .          ---         .              ";


                Console.Clear();
                
                foreach(SolarSystem _system in systems){
                    int i = 0;
                    if(_system != null){
                        Console.WriteLine($"{i}. {_system.getName()}");
                        i++;
                    }
                }
                Star displayStar;
                DeadStar displayDeadStar;
                Planet[] displayPlanets;
                Asteroid[] displayAsteroids;
                Console.Write("Which system would you like to display? ");
                int systemchoice = Convert.ToInt32(Console.ReadLine());
                SolarSystem displaySystem = systems[systemchoice];


                if(displaySystem.getDeadStar() == null){
                displayStar = displaySystem.getStar();
                displayPlanets = displayStar.getPlanets();
                displayAsteroids = displayStar.getAsteroids();

                                int AsteroidTotal = 0;
                int PlanetTotal = 0;
                Console.Clear();

                //Need logic to check which type of star were dealing with. 
                Console.WriteLine(healthy);


                Console.WriteLine($"This is the {displaySystem.getName()} system. ");
                Console.WriteLine("The systems star: ");

                displayStar.display();

                Console.WriteLine("\nThe planets in this system: \n");
                foreach(Planet displayPlanet in displayPlanets){
                    if(displayPlanet != null){
                        displayPlanet.display();
                        PlanetTotal+= 1;
                    }
                    
                }
                Console.WriteLine("\nThe asteroids and comets in this system: \n");
                foreach(Asteroid displayAsteroid in displayAsteroids){
                    if(displayAsteroid != null){
                        displayAsteroid.display();
                        AsteroidTotal += 1;
                    }
                }
                Console.WriteLine($"In total, there are {PlanetTotal} planets and {AsteroidTotal} asteroids/comets in this system. ");

                Console.WriteLine("Press Enter to return to menu. ");
                Console.ReadLine();
                
                }
                else{
                    displayDeadStar = displaySystem.getDeadStar();
                    displayPlanets = displayDeadStar.getPlanets();
                    displayAsteroids = displayDeadStar.getAsteroids();
                int AsteroidTotal = 0;
                int PlanetTotal = 0;
                Console.Clear();

                //Need logic to check which type of star were dealing with. 
                Console.WriteLine(healthy);


                Console.WriteLine($"This is the {displaySystem.getName()} system. ");
                Console.WriteLine("The systems star: ");

                displayDeadStar.display();


                Console.WriteLine("\nThe planets in this system: \n");
                foreach(Planet displayPlanet in displayPlanets){
                    if(displayPlanet != null){
                        displayPlanet.display();
                        PlanetTotal+= 1;
                    }
                    
                }
                Console.WriteLine("\nThe asteroids and comets in this system: \n");
                foreach(Asteroid displayAsteroid in displayAsteroids){
                    if(displayAsteroid != null){
                        displayAsteroid.display();
                        AsteroidTotal += 1;
                    }
                }
                Console.WriteLine($"In total, there are {PlanetTotal} planets and {AsteroidTotal} asteroids/comets in this system. ");

                Console.WriteLine("Press Enter to return to menu. ");
                Console.ReadLine();
                
                }                    

            }
            else if (choice == 4){
            foreach(SolarSystem system in systems){
                if(system != null){
                Star agingStar = system.getStar();
                if(agingStar.getStage() != 2){
                    agingStar.AgeStar();
                }
                else{
                    if(agingStar.getType() == "average"){
                    DeadStar deadStar = new DeadStar(agingStar.getName() , agingStar.getMass(), "White Dwarf");
                    system.setDeadStar(deadStar);
                    deadStar.SetLists(agingStar.getPlanets(), agingStar.getAsteroids());
                    }
                    else{
                    DeadStar deadStar = new DeadStar(agingStar.getName() , agingStar.getMass(), "Neutron Star");
                    system.setDeadStar(deadStar);
                    deadStar.SetLists(agingStar.getPlanets(), agingStar.getAsteroids());
                    }
                }

            }
            }
        }       
        }
        

    }
}