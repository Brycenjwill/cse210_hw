class Asteroid:Body{
    int _comet;
    int _orbit;

    public Asteroid(string name, int mass, int comet, int orbit)
    :base(name, mass){
        _comet = comet;
        _orbit = orbit;
    }
    public override void display()
    {
        string comet;
        if(_comet == 1){
            comet = "comet";
        }
        else{
            comet = "asteroid";
        }
        if(_orbit == 1){
        Console.WriteLine($"{getName()}: A {comet} in orbit of this systems star. ");
        }
        else{
        Console.WriteLine($"{getName()}: A {comet} floating freely in this solar system. ");

        }
    }
}