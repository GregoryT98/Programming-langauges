public class PathDecision
{
    public string PathText { get; set; }
    public string[] PathChoice { get; set; }
    public int PathChosen { get; set; }
    
    public PathDecision(string pathText, string[] pathChoice)
    {
        if (pathChoice.Length < 1 || pathChoice.Length > 4)
        {
            throw new ArgumentException("Path choices must be between 1 and 4.");
        }
        PathText = pathText;
        PathChoice = pathChoice;
        
    }

    public bool IsPathChosen(int choice)
    {
        return PathChosen == choice;
    }

}
