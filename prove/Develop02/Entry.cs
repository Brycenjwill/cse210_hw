public class Entry {
    public string entry;
    public string date;

    
    public string GetEntry(){
        string entry = Console.ReadLine();
        return entry;
    }
    public string CompileEntry(string prompt, string date, string entry){
        string Entry = $"{date} {prompt}:\n{entry}";
        return Entry;
    }
}
