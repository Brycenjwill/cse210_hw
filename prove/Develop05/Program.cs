using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        bool on = true;
        string[] goals;
        while(on == true){
            Console.Write("Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect a choice from the menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1){
                int type;
                Console.Write("The types of Goals are:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\nWhich type of goal would you like to create?");
                type = Convert.ToInt32(Console.ReadLine());
                if (type == 1){
                    createSimple();
                }
                else if (type == 2){
                    createEternal();
                }
                else if (type == 3){
                    createChecklist();
                }
            }   
            else if (choice == 2){
                Console.WriteLine("List Goals");
            }
            else if(choice == 3){
                Console.WriteLine("save goals");
            }
            else if (choice == 4){
                Console.WriteLine("load goals");
            }
            else if (choice == 5){
                Console.WriteLine("RECORD EVENT");
            }
            else if (choice == 0){
                on = false;
            }
        }
    void createSimple(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());
        Simple simple = new Simple(description, name, points);
    }
    void createEternal(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());
        Eternal eternal = new Eternal(description, name, points);
    }
    void createChecklist(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int bonus = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonamount = Convert.ToInt32(Console.ReadLine());
        Checklist checklist = new Checklist(description, name, points, bonus, bonamount);
    }
    void loadGoals(string filename){
        string[] lines = System.IO.File.ReadAllLines(filename);
        int i = 0;
        /*Storing the file into an array*/
        foreach(string line in lines){
            string[] parts = line.Split(",");
            if (i>0){
                string typeName = parts[0];
                
            }
            else{
               goals[0] = parts[0];
            }
            i++;
        }
        

    }

    }

}