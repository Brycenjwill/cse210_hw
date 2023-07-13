class Body{
    private string _name;
    private float _mass;

    public Body(string name, float mass){
        _name = name;
        _mass = mass;
    }
    public string getName(){
        return _name;
    }
    public float getMass(){
        return _mass;
    }
    virtual public void display(){

    }
}