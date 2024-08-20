namespace A2_n11479752;

/// <summary>
/// Represents a class for previewing the canvas with drawing elements.
/// </summary>
public class PreviewCanvas
{
    private readonly ListManager listManager;

    public PreviewCanvas(ListManager listManager)
    {
        this.listManager = listManager;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PreviewCanvas"/> class with the specified list manager.
    /// </summary>
    /// <param name="listManager">The list manager used for handling the drawing.</param>
    public void PreviewCanvasAction()
    {
        listManager.GetCanvas().Show();

        Console.WriteLine("Press enter to continue ...");
        Console.ReadLine();
        throw new ReturnException();
    }
}