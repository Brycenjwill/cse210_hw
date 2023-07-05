public class Entry {
        public string entry;

        public string _prompt;

        public string date;

        public Entry(string prompt, string answer){
            DateTime theCurrentTime = DateTime.Now;
            date = theCurrentTime.ToShortDateString();

            entry = answer;

            _prompt = prompt;


        }
}
class Journal {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry){
            _entries.Add(entry);
        }

        public void DisplayEntries() {
            
            foreach (Entry entry in _entries){
            Console.WriteLine($"Date: {entry.date} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry.entry}");
        }
    }
}

