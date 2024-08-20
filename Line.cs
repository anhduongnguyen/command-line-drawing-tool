namespace A2_n11479752;

/// <summary>
/// Represents a line between two points on the canvas.
/// </summary>
public class Line : Shape 
{
    /// <summary>
    /// Get the symbol used to render the line.
    /// </summary>
    public char Symbol { get; }

    /// <summary>
    /// Get the coordinates where the line starts.
    /// This is an alias for the inherited Position.
    /// </summary>
    private ICoordinates Start => Position;

    /// <summary>
    /// Get the coordinates where the line ends.
    /// </summary>
    public ICoordinates End { get; }

    /// <summary>
    /// Initialise the Line.
    /// </summary>
    /// <param name="start">The non-null starting point of the line.</param>
    /// <param name="end">The non-null ending point of the line.</param>
    /// <param name="symbol">The symbol used to render the line.</param>
    public Line(ICoordinates start, ICoordinates end, char symbol) :
        base(start, end.X - start.X + 1, end.Y - start.Y + 1) {
        End = end;
        Symbol = symbol;
    }

    /// <summary>
    /// Gets the "height" of the line.
    /// This could vary as both position and end are mutable.
    /// </summary>
    public override int Height => End.Y - Start.Y + 1;

    /// <summary>
    /// Get the "width" of the line.
    /// This could vary as both position and end are mutable.
    /// </summary>
    public override int Width => End.X - Start.X + 1;

    /// <summary>
    /// Renders the line onto the canvas.
    /// </summary>
    /// <param name="canvas">
    /// The non-null canvas to which the shape will be added.
    /// </param>
    public override void Draw(Canvas canvas) 
    {
        canvas.Draw(Start.Y, Start.X, End.Y, End.X, Symbol);
    }
}