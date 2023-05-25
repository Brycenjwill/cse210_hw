public class Reference
{
    private string reference;

public Reference(string chapter, string range){
    reference = $"{chapter}:{range}";
    Console.WriteLine(reference);
}
public Reference(string chapter, string beginRange, string endRange){
    reference = $"{chapter}:{beginRange}-{endRange}";
}

}
