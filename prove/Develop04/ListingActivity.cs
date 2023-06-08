public class ListingActivity : Activity{
    private string[] _prompts;
    private string _prompt;


    public ListingActivity(string name, string description) :base(name, description){
        string[] prompts = new string[] {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        _prompts = prompts;
        _prompt = getPrompt();
    }
    public string getPrompt(){
        int length = (_prompts.Length -1 );
        Random r = new Random();
        int rand = r.Next(0, length);
        string prompt = _prompts[rand];
        return prompt;
    }
    public void displayListingActivity(){
        int on = 1;
        int count = 0;
        Console.WriteLine("Get ready...");
        spinner();
        Console.Write("\b\b");
        Console.Write(" ");
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--- {_prompt} ---");
        DateTime date1 = DateTime.Now;
        while(on == 1){
            Console.Write(">");
            Console.ReadLine();
            count +=1;
            TimeSpan diff = DateTime.Now - date1;
            double seconds = diff.TotalSeconds;
            if(seconds >= getDuration()){
                on = 0;
            }
        }
        Console.WriteLine($"You listed {count} items!\n");
        
    }
}