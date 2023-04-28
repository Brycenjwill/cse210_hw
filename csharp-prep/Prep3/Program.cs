using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(1,100);
    
        int userGuess = -1;
        int count = 0;

    while (userGuess != magicNumber) {
        Console.WriteLine("Guess a number. ");
        userGuess = Convert.ToInt32(Console.ReadLine());

        if (userGuess > magicNumber){
            Console.WriteLine("LOWER");

        }
        else if (userGuess < magicNumber){
            Console.WriteLine("HIGHER");
        }
        else if(userGuess == magicNumber){
            Console.WriteLine("YAY!");
        }
        else {
            Console.WriteLine("ERROR?");
        }
        count += 1;
    }
    Console.WriteLine($"You guessed it! It only took you {count} guesses.");
    
    } 
}