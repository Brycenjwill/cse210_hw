class Planet:Body{
    string _type;
    float _AtmosephericDensity;

    public Planet(string name, int mass, string type, float density)
    :base(name, mass){
        _type = type;
        _AtmosephericDensity = density;
    }
    public string getType(){
        return _type;
    }
    public float getAtmosphere(){
        return _AtmosephericDensity;
    }
    public override void display(){
        Console.WriteLine($"{getName()}: A {_type} planet with an atmospheric density of {_AtmosephericDensity}kg/m^3.");
    }
}