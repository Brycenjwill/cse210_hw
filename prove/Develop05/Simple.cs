public class Simple : Goal{
    private bool _done;

    public Simple(string description, string name, int points, bool done) : base(description, name, points){
        _done = done;
    }

    public override int getPoints()
    {
        _done = true;
        return base.getPoints();
    }
    public bool returnDone(){
        return _done;
    }
}