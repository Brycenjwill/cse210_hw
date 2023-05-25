public class Word{
    private string word;
    private int random;
    private int index;

    public Word(int rand){
        random = rand;
    }
    public string chooseUnderline(string[] scrip, int random){ // Where it is currently breaking****
        int ind = 0;
        foreach(string Word in scrip){
            word = Word;
            if (ind == random){
                Underline(ind);

                return word;
            }
            ind += 1;
        }
        return word;
    }
    public int getIndex(){
        return index;
    }
    public void Underline(int index){
        int length = word.Length-1;
        string under = "";
        for(int i = 0; i<=length; i++ ){
            under = under + "_";
        }
        word = under;

    }

}