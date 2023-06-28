public class Checklist : Goal{
    private bool _done;
    private int _quantityGoal;
    private int _quantityBonus;
    private int _timesDone;

    public Checklist(string description, string name, int points, int quantityGoal, int quantityBonus, int timesdone) :base(description, name, points){
        _timesDone = timesdone;
        _quantityBonus = quantityBonus;
        _quantityGoal = quantityGoal;
        _done = false;
    }
    public int getQuantityGoal(){
        return _quantityGoal;
    }
    public override int getPoints()
    {
        if (_timesDone == _quantityGoal){
            return _quantityBonus;
        }
        else{
            _done = true;
            return base.getPoints();
        }
    }
    public bool returnDone(){
        return _done;
    }
}