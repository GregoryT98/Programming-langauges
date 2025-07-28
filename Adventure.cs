
namespace CharacterCreation;

public class Adventure
{
    private PathDecision[] _pathDecisions;

    public Adventure(PathDecision[] pathDecisions)
    {
        this._pathDecisions = pathDecisions;
    }

    private void DisplayPath(PathDecision path)
    {
        Console.foregroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Choice                                ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine(path.PathText);

        for (int i = 0; i < path.PathChoice.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // changes the text color
            Console.Write("   ");
            Console.Write(i + 1);
            Console.ResetColor(); // resets the foreground (text) color
            Console.WriteLine($". {path.PathChoice[i]}");
        }
    }

    private int GetUserChoice()
    {
        COnsole.Write("Your choice (number): ");
        string input = Console.ReadLine();
        int choice = 0;
        while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            input = Console.ReadLine();
        }
        return choice - 1;
    }

    private void DisplayPathResults()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                            Path Results                                 ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
    }

    







}