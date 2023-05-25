public class Scripture{
    private string scriptureText;
    private string[] scriptureArray;
    private int random;
    private int[] randList;
    int i = 0;
    private int arrLen;
    public Scripture(string scripture){
        scriptureText = scripture;
        getArray();
  
    }
    public int getArray(){
        scriptureArray = scriptureText.Split(' ');
        int length = scriptureArray.Length;
        return length;

    }
    public void display(string reference){
        Console.Write($"{reference}");
        foreach(string Word in scriptureArray){
            Console.Write($" {Word}");
        }
        Console.WriteLine("\n\nPress enter to continue, or type quit to end.");
    }




    public void randomNumGen(){
        if (i == 0){
        arrLen = 0;
        int length = getArray();
        randList = new int[length];
        int index = 0;
        for(index = 0; index < length; index++){
            randList[index] = -1;
        }
        }
        i = 1;

        bool done = false;

        while (done == false){

        int ops = 0;
        Random rand = new Random();
        random = rand.Next(0, scriptureArray.Length); 
        foreach(int numb in randList){
            if (numb == random){
                ops = 1;
            } 

        }
        done = true;
        if (ops == 1){
            done = false;
        }
 
        }

            randList[arrLen] = random;
            arrLen += 1;
            Word word = new Word(random);
            string replacement = word.chooseUnderline(scriptureArray, random);
            reviseList(replacement, random);

    }
    public void reviseList(string word, int i){
        int ind = i;
        scriptureArray[ind] = word;
    }

    
}