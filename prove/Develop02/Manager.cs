class FileManager{
    public void SaveJournal(Journal journal, string filename) {

        using (StreamWriter outputFile = new StreamWriter(filename)) {

            foreach (var entry in journal._entries) {

                string data = $"{entry.date};{entry._prompt};{entry.entry}";
                outputFile.WriteLine(data);
            }
        }
    }

    public Journal LoadJournal(string filename) {

        string[] lines = System.IO.File.ReadAllLines(filename);
        Journal journal = new Journal ();

        foreach (string line in lines) {

            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry inst = new Entry(prompt,text);
            inst.date = date;
            inst._prompt = prompt;
            inst.entry = text;

            journal._entries.Add(inst);
        }

        return journal;
    }
}