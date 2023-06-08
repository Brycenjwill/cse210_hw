public class BreathingActivity : Activity{
    private int[] countdown;
    private int countdownLength;
    private int _breathCycles;

    public BreathingActivity(string name, string description) : base ( name, description){
        int [] count = new int[5]  { 5,  4, 3, 2, 1};
        countdown = count;
    }
    public void displayBreath(){
        Console.WriteLine("Get ready...");
        countdownLength = countdown.Length;
        spinner();
        Console.Write("\b'\b");
        Console.Write(" ");
        Console.WriteLine();
        //Logic to display count downs for as long as there is time left.
        _breathCycles = getDuration() / countdownLength; //Gets how many times it should run (-1 if there is a remainder)
        for(int i = 1; i <= _breathCycles; i++){
            if(i%2 != 0){
                Console.Write("Breath in...");
                displayCounter();
                Console.WriteLine();
            }
            else{
                Console.Write("Breath out...");
                displayCounter();
                Console.WriteLine("\n");

            }
        }

    }
    public void displayCounter(){
        foreach(int num in countdown){
            Console.Write(num);

            pause(1000);
            Console.Write("\b");
        }
        Console.Write("0");
    }
}