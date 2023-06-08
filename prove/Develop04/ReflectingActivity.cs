public class ReflectingActivity : Activity{
    private string[] _prompts;
    private string _prompt;
    private string[] _questions;
    private int[] _countdown;


    public ReflectingActivity( string name, string description) : base( name, description){
        string[] prompts = new string[] {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        _prompts = prompts;
        _prompt = getPrompt();
        string[] questions = new string[] {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?","How did you feel during this experience?","How did you feel after this experience?","How would you feel if a friend or loved one had gone through this experience?"};
        _questions = questions;
        int[] countdown = new int[] {5,4,3,2,1};
        _countdown = countdown;
    }
    public string getPrompt(){
        int length = (_prompts.Length -1 );
        Random r = new Random();
        int rand = r.Next(0, length);
        string prompt = _prompts[rand];
        return prompt;
    }
    public string getQuestion(){
        int length = (_questions.Length -1 );
        Random r = new Random();
        int rand = r.Next(0, length);
        string question = _questions[rand];
        string[] arr = new string[_questions.Length-1];
        int ind = 0;
        for(int i= 0; i <= _questions.Length-1; i++ ){
            if(i!= rand){
                arr[ind] = _questions[i];
                ind += 1;
            }
        }
        _questions = arr;
        return question;

        
    }
    public void displayRelfection(){
        Console.WriteLine("Get ready... ");
        spinner();
        Console.WriteLine("Consider the followind prompt:\n");
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they related to this experience. You may begin in: ");
        displayQuestions();
    }
    public void displayQuestions(){
        Console.Clear();
        int lengthofspin = 5;
        int duration = getDuration();
        for(int i= 1; i <= duration / lengthofspin; i++){
            string question = getQuestion();
            Console.Write($"> {question}");
            spinner();
            Console.WriteLine();
        }
    }
    public void displayCounter(){
        foreach(int num in _countdown){
            Console.Write(num);

            pause(1000);
            Console.Write("\b");
        }
        Console.Write("0");
    }
}