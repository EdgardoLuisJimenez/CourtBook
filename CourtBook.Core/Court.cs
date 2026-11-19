namespace CourtBook.Core;

public class Court
{
    public string Name {get; set;} = "";

    public string Description ()
    {
        return $"Cancha: {Name}" ;
    }
}
