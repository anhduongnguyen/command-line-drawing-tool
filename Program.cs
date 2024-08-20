namespace A2_n11479752 {
    public class Program {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the Simple Drawing Editor!");
            Console.WriteLine("");
            Canvas canvas = new Canvas(); 
            DrawingEditor drawingEditor = new DrawingEditor(canvas);
      

            Menu mainMenu = new Menu("Main menu - please select an option",
                new MenuItem("New     -> Create new drawing",() => drawingEditor.NewDrawingAction()),
                new MenuItem("Open    -> Open existing drawing"),
                new Menu("Edit    -> Edit drawing",
                    new MenuItem("Point   -> Add point to drawing", () => drawingEditor.AddPointAction()),
                    new MenuItem("Line    -> Add line to drawing", () => drawingEditor.AddLineAction()),
                    new MenuItem("Text    -> Add text to drawing", () => drawingEditor.AddTextAction()),
                    new MenuItem("Preview -> Preview drawing", () => drawingEditor.PreviewCanvasAction()),
                    new MenuItem("List    -> List elements in drawing", () => drawingEditor.ListElementsAction()),
                    new MenuItem("Delete  -> Delete element from drawing", () => drawingEditor.DeleteElementAction()),
                    new ReturnAction("Return  -> Return to previous menu")
                ),                
                new MenuItem("Save    -> Save drawing"),
                new MenuItem("Save as -> Save drawing as ..."),
                new CloseProgram("Close   -> Exit from system")
            );
            mainMenu.Action();
        }
    }
}