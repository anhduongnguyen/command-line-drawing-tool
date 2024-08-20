namespace A2_n11479752;

/// <summary>
/// Represents a visible point.
/// </summary>
public class Point : Shape {
    /// <summary>
    /// Get the symbol used to display the point.
    /// </summary>
    public char Symbol { get; }

    /// <summary>
    /// Initialise the Point.
    /// </summary>
    /// <param name="position">The position of the point.</param>
    /// <param name="symbol">The symbol used to display the point.</param>
    public Point( ICoordinates position, char symbol ) : base( position, width: 1, height: 1 ) {
        Symbol = symbol;
    }

    /// <summary>
    /// Draws the point onto the specified canvas.
    /// </summary>
    /// <param name="canvas">The canvas to which the point will be added.</param>
    public override void Draw( Canvas canvas ) {
     
        canvas.Draw( Position.Y, Position.X, Symbol );
    }
}