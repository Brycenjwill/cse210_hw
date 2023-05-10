using System;

class Program
{
    static void Main(string[] args)
    {
        bool on = true;


        while(on == true)
        {
            Console.WriteLine("Welcome to teh Journal Program!");
            Console.WriteLine("Please selct one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1){ // Write
                char redo = 'n'; //Added code so that you can redo your entry 
                while (Char.ToLower(redo) == 'n'){
                Prompt gotPrompt = new Prompt();

                string prompt = gotPrompt.PromptGen();
                Console.WriteLine(prompt);

                Entry newentry = new Entry();
                newentry.entry = newentry.GetEntry();
                Console.WriteLine($"Your entry is'{newentry.entry}', is that okay? (Y/N)");
                redo = Convert.ToChar(Console.ReadLine());
                }
            }
            else if(choice == 2){ // Display
                break;
            }
            else if (choice == 3){ // Load
                break;
            }
            else if (choice == 4){ //Save
                break; //uses entry class, which adds to journal file
            }
            else if (choice == 5){ //Quit
                on = false;
            }
        }
    }
}