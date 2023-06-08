public class Activity{
    private int _duration;
    private string _name;
    private string _description;

    public Activity( string name, string description){

        _name = name;
        _description = description;
    }
    public void makeDuration(){
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? (max 60)");
        int duration = Convert.ToInt32(Console.ReadLine());
        _duration = duration;
    }
    public void displayStart(){ //Displays description, which contains all section info, on start
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}");
    }
    public void pause(int len){ //Puts the console to sleep for 100 times num seconds
        Thread.Sleep(len);
    }
    public void endMessage(){
        Console.WriteLine("Well Done!\n");

        Console.WriteLine($"You have completed another {_duration} seconds in the {_name}.");

    }
    public int getDuration(){
        return _duration;
    }
    public void spinner(){
        for(int i = 0; i < 2; i++){
            for(int s = 0; s <= 7; s ++ ){
                char symbol = 'e';
                switch(s){
                    case 0: 
                    symbol = '\\';
                    break;
                    case 1:
                    symbol = '|';
                    break;
                    case 2:
                    symbol = '/';
                    break;
                    case 3:
                    symbol = '-';
                    break;
                    case 4:
                    symbol = '\\';
                    break;
                    case 5:
                    symbol = '|';
                    break;
                    case 6:
                    symbol = '/';
                    break;
                    case 7:
                    symbol = '-';
                    break;
                    default: 
                    Console.WriteLine("Error.");
                    break;
                }
                Console.Write(symbol);
                pause(325);
                Console.Write("\b");
            }

        }
    }
}