namespace A2_n11479752;

/// <summary>
/// Represents a class for adding text to a drawing.
/// </summary>
public class AddText
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddText"/> class.
    /// </summary>
    /// <param name="listManager">Manages the drawing's element list.</param>
    private readonly ListManager listManager;

    /// <summary>
    /// Performs the action of adding text to the drawing.
    /// </summary>
    public AddText(ListManager listManager)
    {
        this.listManager = listManager;
    }

    /// <summary>
    /// Performs the action of adding text to the drawing.
    /// </summary>
    public void AddTextAction()
    {
        Console.WriteLine("");
        Console.WriteLine("Add text to drawing:");
        Console.WriteLine("");

        CheckInput.GetCoordinates("X: ", out var x);
        CheckInput.GetCoordinates("Y: ", out var y);
        string text = CheckInput.GetLabel();

        listManager.GetPosition(out var position);

        Text label = new Text(new Coordinates(x, y), text);
        listManager.InsertElement(label, position);
        throw new ReturnException();
    }
}