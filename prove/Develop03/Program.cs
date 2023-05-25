using System;

class Program
{
    static void Main(string[] args)
    {
        bool on = true;
 

        Reference refe = new Reference("1 Nephi", 2, 15);
        Scripture scripture = new Scripture("And my father dwelt in a tent.");
        string refer = refe.getRef();
        int i = 0;
        int runs = scripture.getArray()-1;
        Console.Clear();
        scripture.display(refer);

        while(on == true){
            string choice = Console.ReadLine();
            Console.Clear();
        
            scripture.randomNumGen();


            scripture.display(refer);
            if (choice == "quit"){
                on = false;
            }
            if (i == runs){
                on = false;
            }
            i += 1;
        }
    }
}