public class Goal{
    private int _points;
    private string _goalName;
    private string _description;

    public Goal(string description, string name, int points){
        _goalName = name;
        _description = description;
        _points = points;
    }
    public void displayGoals(){

    }
    public void loadFile(){
        
    }
    public void saveToFile(){

    }
    public virtual int getPoints(){

        return _points;
    }
    public string getDescription(){
        return _description;
    }
    public string getName(){
        return _goalName;
    }

}