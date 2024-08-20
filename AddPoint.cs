namespace A2_n11479752;

/// <summary>
/// Represents a class for adding a point to a drawing.
/// </summary>
public class AddPoint
{
    private readonly ListManager listManager;

    /// <summary>
    /// Initializes a new instance of the <see cref="AddPoint"/> class.
    /// </summary>
    /// <param name="listManager">Manages the drawing's element list.</param>
    public AddPoint(ListManager listManager)
    {
        this.listManager = listManager;
    }

    public void AddPointAction()
    {
        Console.WriteLine("");
        Console.WriteLine("Add point to drawing:");
        Console.WriteLine("");

        CheckInput.GetCoordinates("X: ", out var x);
        CheckInput.GetCoordinates("Y: ", out var y);

        char symbol = CheckInput.GetSymbol();

        listManager.GetPosition(out var position);

        Point point = new Point(new Coordinates(x, y), symbol);
        listManager.InsertElement(point, position);
        throw new ReturnException();
    }
}