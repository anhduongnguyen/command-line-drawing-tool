namespace A2_n11479752;

/// <summary>
/// Abstract representation of an (x,y) position.
/// </summary>
public interface ICoordinates 
{
    /// <summary>
    /// Get the horizontal (x) offset to the position.
    /// </summary>
    public int X { get; }

    /// <summary>
    /// Get the vertical (x) offset of the position.
    /// </summary>
    public int Y { get; }
}