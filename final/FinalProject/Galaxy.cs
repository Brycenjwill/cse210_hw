class Galaxy{
    string _name;
    SolarSystem[] _systemList;
    SupermassiveBlackHole _blackHoleName;

    public Galaxy(string name, SolarSystem[] systemList, SupermassiveBlackHole blackHoleName){
        _name = name;
        _systemList = systemList;
        _blackHoleName = blackHoleName;
    }
    public void setSystems(SolarSystem system){
        int i = 0;
        foreach(SolarSystem _system in _systemList){
            if(_system == null){
                _systemList[i]= system;
                return;
            }
            i++;
        }
    }
    public void displaySolarSystems(){

    }
    public SupermassiveBlackHole getBlackHoleName(){
        return _blackHoleName;
    }
    public string getName(){
        return _name;
    }
}