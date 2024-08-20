namespace A2_n11479752;
   
/// <summary>
/// Represents a class for creating a new drawing.
/// </summary>
public class NewDrawing
{
    private readonly ListManager listManager;

    public NewDrawing(ListManager listManager)
    {
        this.listManager = listManager;
    }

    /// <summary>
    /// Performs the action of creating a new drawing.
    /// </summary>
    public void NewDrawingAction()
    {
        if (listManager.DrawingChanged)
        {
            Console.WriteLine("");
            Console.WriteLine("Edits have been made to the current drawing.");
            Console.WriteLine("");
            Console.WriteLine("Do you want to discard them?");
            Console.WriteLine("");
            Console.WriteLine("Yes -> Discard changes");
            Console.WriteLine("No  -> Cancel");
            Console.Write("? ");

            string? input = Console.ReadLine()?.Trim().ToLower();

            switch (input)
            {
                case "yes":
                    listManager.Clear();
                    Console.WriteLine("\tDrawing successfully created!");
                    Console.WriteLine("");
                    break;
                case "no":
                    Console.WriteLine("\tOperation cancelled.");
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("\tInvalid response. Operation cancelled.");
                    Console.WriteLine("");
                    break;
            }
        }
        else
        {
            Console.WriteLine("\tDrawing successfully created!");
            Console.WriteLine("");
        }

        throw new ReturnException();
    }
}