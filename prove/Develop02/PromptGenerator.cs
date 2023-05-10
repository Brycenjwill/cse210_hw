public class Prompt
{
    public List<String> Prompts = new List<String> {
        "What was the best part of your day?",
        "What was something you were grateful for today?",
        "Where did you go today?",
        "What was something fun you did today?",
        "Did you talk to anyone interesting today?",
        "Did you meet anyone new today?",
        "What do you want to do tomorrow"

    };
    public Random numberGenerator = new Random();


public string PromptGen(){
    int index = numberGenerator.Next(Prompts.Count);
    string Prompt = Prompts[index];
    return Prompt;
}
}

