public class Eternal : Goal{
    private int _timesDone;


    public Eternal(string description, string name, int points) :base(description, name, points){
        _timesDone = 0;
    }
    public override int getPoints()
    {
        return base.getPoints();
    }

    
}