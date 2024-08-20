namespace A2_n11479752;

/// <summary>
/// The conditions satisfied by objects which can be drawn on a canvas.
/// </summary>
public interface IDrawable 
{
    /// <summary>
    /// Get the position of the object.
    /// </summary>
    ICoordinates Position { get; }

    /// <summary>
    /// Render an object in the canvas.
    /// </summary>
    /// <param name="canvas">The non-null canvas which will display the object.</param>
    void Draw( Canvas canvas );
}