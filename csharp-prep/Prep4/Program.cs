using System;

class Program
{
    static void Main(string[] args)
    {
        

        float average = 0;  
        int length = 0;  
        var numbers = new List<int>();
        while(true){
            Console.WriteLine("Choose a number to add: ");
            int Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to add another number? (Y/N)");

            string choice = Console.ReadLine();

            numbers.Add(Input);
            choice = choice.ToLower();

            

            if (choice[0] == 'n'){
                break;
            }


        }
        int total = 0;
        foreach (var num in numbers) {
            total += num;
        }
        length = numbers.Count();
        average = (float)total / (float)length;

        Console.WriteLine($"The total is {total}.");
        Console.WriteLine($"The average is {average}.");
    }
    
}