class SolarSystem{
    private string _name;
    private Star _StarName;

    public SolarSystem(string name, Star StarName){
        _name = name;
        _StarName = StarName;
    }
    public string getName(){
        return _name;
    }
}