

public class CharacterClass
{
    public string partyName { get; set; }
    public string partyClass { get; set; }

    public CharacterClass(string partyName, string partyClass)
    {
        this.partyName = partyName;
        this.partyClass = partyClass;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($" this is {partyName} and they are a {partyClass}");
    }
}