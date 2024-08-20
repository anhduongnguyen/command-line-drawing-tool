namespace A2_n11479752;

/// <summary>
/// Class to represent a point in the canvas.
/// </summary>
public class Coordinates : ICoordinates
{
    /// <summary>
    /// The point's horizontal position.
    /// </summary>
    public int X { get; }

    /// <summary>
    /// The point's vertical position.
    /// </summary>
    public int Y { get; }

    /// <summary>
    /// Set the initial location of the point.
    /// </summary>
    /// <param name="x">The point's initial horizontal location.</param>
    /// <param name="y">The point's initial vertical location.</param>
    public Coordinates(int x, int y)
    {
        X = x;
        Y = y;
    }
}