namespace A2_n11479752;

/// <summary>
/// Represents a class for adding a line to a drawing.
/// </summary>
public class AddLine
{
    private readonly ListManager listManager;

    /// <summary>
    /// Initializes a new instance of the <see cref="AddLine"/> class.
    /// </summary>
    /// <param name="listManager">Manages the drawing's element list.</param>
    public AddLine(ListManager listManager)
    {
        this.listManager = listManager;
    }

    /// <summary>
    /// Performs the action of adding a line to the drawing.
    /// </summary>
    public void AddLineAction()
    {
        Console.WriteLine("");
        Console.WriteLine("Add line to drawing:");
        Console.WriteLine("");

        CheckInput.GetCoordinates("Start X: ", out var startX);
        CheckInput.GetCoordinates("Start Y: ", out var startY);
        CheckInput.GetCoordinates("End X: ", out var endX);
        CheckInput.GetCoordinates("End Y: ", out var endY);

        char symbol = CheckInput.GetSymbol();

        listManager.GetPosition(out var position);

        Line line = new Line(new Coordinates(startX, startY), new Coordinates(endX, endY), symbol);
        listManager.InsertElement(line, position);
        throw new ReturnException();
    }
}