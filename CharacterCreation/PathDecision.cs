public class PathDecision
{
    public string PathText { get; set; }
    public string[] PathChoice { get; set; }
    public int PathChosen { get; set; }
    
    public PathDecision(string pathText, string[] pathChoice, int pathChosen)
    {
        PathText = pathText;
        PathChoice = pathChoice;
        PathChosen = pathChosen;
    }

    public bool IsPathChosen(int choice)
    {
        return PathChosen == choice;
    }

}
