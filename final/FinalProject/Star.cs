class Star:Body{
    private int _age;
    private int _stage;
    private int _type; //0 for average, 1 for massive.
    private string[] inOrbitList;

    public Star(string name, float mass, int age,  int stage, int type)
    :base(name, mass){
        age = _age;
        stage = _stage;
        type = _type;
        
    }
}