class DeadStar{
    private string _type;
    private string _name;
    private float _mass;
    Planet[] _planetList;
    Asteroid[] _asteroidList;
    public DeadStar(string name, float mass, string type){
        _type = type;
        _name = name;
        _mass = mass;
    }
    public void SetLists(Planet[] planetList, Asteroid[] asteroidList){
        _planetList = planetList;
        _asteroidList = asteroidList;
    }
    
    public void display()
    {
        Console.WriteLine($"{_name}: A {_type} with a mass of {_mass} Solar Mass Units. ");
    }
    public Planet[] getPlanets(){
        return _planetList;
    }
    public Asteroid[] getAsteroids(){
        return _asteroidList;
    }
}