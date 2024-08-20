namespace A2_n11479752;

/// <summary>
/// Represents a block of text at a location in the canvas.
/// </summary>
public class Text : Shape {

    /// <summary>
    /// Gets the text displayed when it is rendered.
    /// </summary>
    public string LabelText { get; }

    /// <summary>
    /// Initialise the Label.
    /// </summary>
    /// <param name="start">
    /// The position at which the beginning of the string is added.
    /// </param>
    /// <param name="text">
    /// The text to be displayed.
    /// </param>
    public Text(ICoordinates start, string text)
        : base(start, text.Length, 1) {
        LabelText = text;
    }

    /// <summary>
    /// Adds the text to the canvas.
    /// </summary>
    /// <param name="canvas">
    /// The non-null canvas object that will display the text.
    /// </param>
    public override void Draw(Canvas canvas) {
        canvas.Draw(Position.Y, Position.X, LabelText);
    }
}