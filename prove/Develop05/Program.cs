using System;
using System.IO;
class Program
{
    static string filename;

    static void Main(string[] args)
    {

    string[] loaded = new string[15];
    Goal[] goalList = new Goal[15];

        bool on = true;
        int run = 0;

        while(on == true){
            if(run == 0){ /*Code to tell user to load old goals before anything else*/
            Console.Write("Note: You should always load any previous goal files before creating new goals to avoid overwriting old goals when saving later. \n");
            run ++;
        }
            Console.WriteLine("Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect a choice from the menu: ");

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
                /*Next part to handle :)*/
                }
            
            else if(choice == 3){
                Console.WriteLine("Are you sure you are ready to save?\n   0. No, take me back\n   1. Yes.");
                int areYouSure = Convert.ToInt32(Console.ReadLine());
                if(areYouSure == 0){
                }
                else{
                    Console.Write("What is the name of the file you want to load? ");
                    filename = Console.ReadLine();
                    saveGoals(filename, loaded);
                }
            }
            else if (choice == 4){
                Console.Write("What is the name of the file you want to load? ");
                filename = Console.ReadLine();
                loaded = loadGoals(filename);
                goalList = createGoalsFromLoad(loaded);
            }
            else if (choice == 5){
                Console.WriteLine("RECORD EVENT"); /* Next to do! Need to use both Goalist and loaded arrays to increment values. The actual objects are in Goalist, loaded is mostly for display purposes to not require get statements as much*/
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
        Simple simple = new Simple(description, name, points, false);
        int i = 0;
        bool first = true;
        foreach(Goal goal in goalList){
            if(first == true){
            if(goal == null){
                goalList[i] = simple;
                first = false;   
            }
            }
            i ++;

        }
        first = true;
        int index = 0;
        foreach(string entry in loaded){
            if(first == true){
            if(entry == ""){
                loaded[index] = "Simple:" +name+","+description+","+Convert.ToString(points)+","+"false";
                first = false;
            }
            if(entry == null){
                loaded[index] = "Simple:" +name+","+description+","+Convert.ToString(points)+","+"false";
                first = false;
            }
            }
            index ++;
        }
    }
    void createEternal(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());
        Eternal eternal = new Eternal(description, name, points);
        int i = 0;
        bool first = true;
        foreach(Goal goal in goalList){
            if(first == true){
            if(goal == null){
                goalList[i] = eternal;
                first = false;
            }
            }
            i ++;
        }
        int index = 0;
        first = true;
        foreach(string entry in loaded){
            if(first == true){
            if(entry == ""){
                loaded[index] = "Eternal:" +name+","+description+","+Convert.ToString(points);
                first = false;
            }
            if(entry == null){
                loaded[index] = "Eternal:" +name+","+description+","+Convert.ToString(points);
                first = false;
            }
            }
            index++;
        }
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
        Checklist checklist = new Checklist(description, name, points, bonus, bonamount, 0);
        int i = 0;
        bool first = true;
        foreach(Goal goal in goalList){
            if(first==true){
            if(goal == null){
                goalList[i] = checklist;
                first = false;
            }
            }
            i ++;
        }
        int index = 0;
        first = true;
        foreach(string entry in loaded){
            if(first == true){
            if(entry == ""){
                loaded[index] = "Checklist:" +name+","+description+","+Convert.ToString(points)+","+Convert.ToString(bonamount)+","+Convert.ToString(bonus)+","+"0";
                first = false;
                
            }
            if(entry == null){
                loaded[index] = "Checklist:" +name+","+description+","+Convert.ToString(points)+","+Convert.ToString(bonamount)+","+Convert.ToString(bonus)+","+"0";
                first = false;
                
            }
            }
            index ++;
        }

    }
    string[] loadGoals(string filename){
    string[] goals =  new string[15];
        string[] lines = System.IO.File.ReadAllLines(filename);
        int i = 0;
        /*Storing the file into an array*/
        foreach(string line in lines){

            if (i>0){

                goals[i] = line;
            }
            else{
                       
               goals[0] = lines[0];
            }
            i++;
        }
        return goals;
        

    }
    Goal[] createGoalsFromLoad(string[] goals){
        int i = 0;
        Goal[] goalList = new Goal[15];
        foreach(string line in goals){
            if(line != "")
            {
                if(line != null){
            if(i>0){
                string type = line.Split(":")[0];
                string info = line.Split(":")[1];
                if (type == "Simple"){
                    string[] classInfo = info.Split(",");
                    string name = classInfo[0];
                    string description = classInfo[1];
                    string points = classInfo[2];
                    int pts = Convert.ToInt32(points);
                    bool done = Convert.ToBoolean(classInfo[3]);
                    Simple simple = new Simple(description, name, pts, done); /*Need to do same for both eternal and checklist goals.*/
                    goalList[i-1] = simple;
            
                }
                else if (type == "Eternal"){
                    string[] classInfo = info.Split(",");
                    string name = classInfo[0];
                    string description = classInfo[1];
                    string points = classInfo[2];
                    int pts = Convert.ToInt32(points);
                    Eternal eternal = new Eternal(description, name, pts);
                    goalList[i-1] = eternal;
                }
                else if (type == "Checklist"){
                    string[] classInfo = info.Split(",");
                    string name = classInfo[0];
                    string description = classInfo[1];
                    string points = classInfo[2];
                    int pts = Convert.ToInt32(points);
                    string bonus = classInfo[3];
                    int bns = Convert.ToInt32(bonus);
                    string bnsamount = classInfo[4];
                    int bnsmt = Convert.ToInt32(bnsamount);
                    string done = classInfo[5];
                    int dn = Convert.ToInt32(done);
                    Checklist checklist = new Checklist(description, name, pts, bnsmt, bns, dn);

                    goalList[i-1] = checklist;
                }
            }
            }
            i++;
            }}
            return goalList;
    }
    void saveGoals(string filename, string[] load){
        File.WriteAllText(filename, String.Empty);
    using (StreamWriter outputFile = new StreamWriter(filename))
{
    foreach(string line in load){
        outputFile.WriteLine(line);
    }
}
    }
    }

}