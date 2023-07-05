using System;


class Program
{
    static void Main(string[] args)
    {
        bool on = true;
        Journal journal = new Journal();
        FileManager manager = new FileManager();


        while(on == true)
        {
            Console.WriteLine("Welcome to teh Journal Program!");
            Console.WriteLine("Please selct one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1){
                Prompt gotPrompt = new Prompt();

                string prompt = gotPrompt.PromptGen();
                Console.WriteLine(prompt);
                string answer = Console.ReadLine();

                Entry newentry = new Entry(prompt, answer);
                journal.AddEntry(newentry);
                

            }
            else if(choice == 2){ // Display
                journal.DisplayEntries();
            }
            else if (choice == 3){ // Load
                Console. Write("What it the filename? ");
                string filename = Console.ReadLine();

                manager.SaveJournal(journal, filename);
            }
            else if (choice == 4){ //Save
                Console. Write("What it the filename? ");
                string filename = Console.ReadLine();

                manager.SaveJournal(journal, filename);
            }
            else if (choice == 5){ //Quit
                on = false;
            }
        }
    }
}