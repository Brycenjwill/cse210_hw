using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = SqureNumber(number);

        DisplayResult(numberSquared, name);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program! ");
    }
    static string PromptUserName(){
        Console.WriteLine("Input your name: ");
        string GotName = Console.ReadLine();
        return GotName;
    }
    static int PromptUserNumber(){
        Console.WriteLine("Input your favorite number: ");
        int GotNumber = Convert.ToInt32(Console.ReadLine());
        return GotNumber;
    }
    static int SqureNumber(int num){
        int NumberSquared = num * num;
        return NumberSquared;
    }
    static void DisplayResult(int square, string name){
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}