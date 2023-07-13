class SolarSystem{
    private string _name;
    private Star _StarName;
    private DeadStar _deadStarName;

    public SolarSystem(string name, Star StarName){
        _name = name;
        _StarName = StarName;
    }
    public string getName(){
        return _name;
    }
    public Star getStar(){
        return _StarName;
    }
    public void setDeadStar(DeadStar deadstar){
        _deadStarName = deadstar;
    }
    public DeadStar getDeadStar(){
        return _deadStarName;
    }
}