namespace A2_n11479752;

/// <summary>
/// Represents a Drawing Editor that provides actions for managing a drawing.
/// </summary>
public class DrawingEditor
{
    private readonly ListManager listManager;

    public DrawingEditor(Canvas canvas)
    {
        this.listManager = new ListManager(canvas);
    }

    /// <summary>
    /// Performs the action of creating a new drawing.
    /// </summary
    public void NewDrawingAction()
    {
        NewDrawing newDrawing = new NewDrawing(listManager);
        newDrawing.NewDrawingAction();
    }
    
    /// <summary>
    /// Performs the action of adding a point to the drawing.
    /// </summary>
    public void AddPointAction()
    {
        AddPoint addPoint = new AddPoint(listManager);
        addPoint.AddPointAction();
    }

    /// <summary>
    /// Performs the action of adding a line to the drawing.
    /// </summary>
    public void AddLineAction()
    {
        AddLine addLine = new AddLine(listManager);
        addLine.AddLineAction();
    }

    /// <summary>
    /// Performs the action of adding text to the drawing.
    /// </summary>
    public void AddTextAction()
    {
        AddText addText = new AddText(listManager);
        addText.AddTextAction();
    }

    /// <summary>
    /// Performs the action of listing elements in the drawing.
    /// </summary>
    public void ListElementsAction()
    {
        listManager.ListElements();
    }

    /// <summary>
    /// Performs the action of deleting an element from the drawing.
    /// </summary>
    public void DeleteElementAction()
    {
        listManager.DeleteElement();
    }

    /// <summary>
    /// Performs the action of previewing the canvas with the drawing elements.
    /// </summary>
    public void PreviewCanvasAction()
    {
        PreviewCanvas previewCanvas = new PreviewCanvas(listManager);
        previewCanvas.PreviewCanvasAction();
    }
}