class Star:Body{
    private int _stage;
    private string _type; //0 for average, 1 for massive.
    private string _stageType;
    Planet[] _planetList;
    Asteroid[] _asteroidList;

    public Star(string name, float mass, int stage, int type)
    :base(name, mass){
        string stringType;
        stage = _stage;
        if(type == 0){
            stringType = "average";
        }
        else{
            stringType = "massive";
        }
        _type = stringType;
        Planet[] list = {null, null, null, null, null, null, null, null};
        _planetList = list;
        Asteroid[] _list = {null, null, null, null, null, null, null, null};
        _asteroidList = _list;
        _stageType = "";

        
    }
    public string getType(){
        return _type;
    }
    public int getStage(){
        return _stage;
    }
    public void appendPlanets(Planet planet){
        int i = 0;
        if(_planetList[0] == null){
            _planetList[0] = planet;
        }
        else{
            foreach(Planet _planet in _planetList){
                if(_planet == null){
                    _planetList[i] = planet;
                    return;
                }
                i++;
            }
        }

    }
    public void appendAsteroids(Asteroid asteroid){
        int i = 0;
        if(_asteroidList[0] == null){
            _asteroidList[0] = asteroid;
        }
        else{
            foreach(Asteroid _asteroid in _asteroidList){
                if(_asteroid == null){
                    _asteroidList[i] = asteroid;
                    return;
                }
                i++;
            }
        }
    }

    public Planet[] getPlanets(){
        return _planetList;
    }
    public Asteroid[] getAsteroids(){
        return _asteroidList;
    }
    public void AgeStar(){
        _stage += 1;
        if(_stage == 1){
            if(_type == "average"){
                _stageType = "Red Giant";
            }
            else{
                _stageType = "Red Supergiant";
            }
        if(_stage == 2){
            if(_type == "average"){
                _stageType = "Planetary Nebula";
            }
            else{
                _stageType = "Supernova";
            }
        }
        }
    }

    public override void display()
    {
        Console.WriteLine($"{getName()}: A stage {_stage} {_type} {_stageType} star in the center of this system. ");
    }
    
}