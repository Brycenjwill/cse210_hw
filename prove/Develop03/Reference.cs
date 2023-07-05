public class Reference
{
    private string reference;

public Reference(string book, int chapter, int range){
    reference = $"{book} {chapter}:{range}";

}
public Reference(string book, int chapter, int beginRange, int endRange){
    reference = $"{book} {chapter}:{beginRange}-{endRange}";
}
public string getRef(){
    return reference;
}

}