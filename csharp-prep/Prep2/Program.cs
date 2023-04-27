using System;

class Program
{
    static void Main(string[] args)
    {
        char letter = 'F';
        Console.WriteLine("What is your grade percentage? ");
        int percent = Convert.ToInt32(Console.ReadLine());

        if (percent >= 70) {

            if (percent >= 80){

            if (percent >= 90){
                letter = 'A';
            }
            else {
                letter = 'B';
            }
            }


            else {
                letter = 'C';
            }
            Console.WriteLine($"You Passed! You got a {letter}.");
        }
        else{
            if (percent < 60){
                    letter = 'F';
            }
            else{
                letter = 'D';
            }
            Console.WriteLine($"You failed. You got a {letter}.");
            }
        
        }

    }
