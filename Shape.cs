namespace A2_n11479752;

/// <summary>
/// Represents a drawable object which has a position, width, and height. 
/// </summary>
public abstract class Shape: IDrawable {
    /// <summary>
    /// Gets the position of the "top-left" corner of the object.
    /// </summary>
    public ICoordinates Position { get; }

    /// <summary>
    /// Gets the width of the object.
    /// </summary>
    public virtual int Width { get; }

    /// <summary>
    /// Gets the height of the object.
    /// </summary>
    public virtual int Height { get; }

    /// <summary>
    /// Initialise a new instance of the shape class.
    /// </summary>
    /// <param name="position">The position of the object</param>
    /// <param name="width">The width of the object</param>
    /// <param name="height">The height of the object</param>
    protected Shape ( ICoordinates position, int width, int height ) {
        Position = position;
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Override Draw to render a shape onto the canvas.
    /// </summary>
    /// <param name="canvas">
    /// The non-null canvas to which the shape will be added.
    /// </param>
    public abstract void Draw( Canvas canvas );
}