namespace A2_n11479752;

/// <summary>
/// Manages a list of drawable elements on a canvas.
/// </summary>
    public class ListManager
    {
        private readonly Canvas canvas;
        private readonly List<IDrawable> drawingElements;
        private bool drawingChanged;

        public bool DrawingChanged => drawingChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListManager"/> class with the specified canvas.
        /// </summary>
        /// <param name="canvas">The canvas on which the drawing is managed.</param>
        public ListManager(Canvas canvas)
        {
            this.canvas = canvas;
            this.drawingElements = new List<IDrawable>();
        }

        /// <summary>
        /// Inserts a drawable element at the specified position in the drawing.
        /// </summary>
        /// <param name="element">The drawable element to insert.</param>
        /// <param name="position">The position at which to insert the element.</param>
        public void InsertElement(IDrawable element, int position)
        {
            if (position < 0 || position > drawingElements.Count)
            {
                Console.WriteLine("Please supply a valid position.");
                return;
            }

            drawingElements.Insert(position, element);
            canvas.Clear();

            foreach (var drawable in drawingElements.OrderBy(e => drawingElements.IndexOf(e)))
            {
                drawable.Draw(canvas);
            }

            drawingChanged = true;
        }

        /// <summary>
        /// Deletes an element from the drawing based on user input.
        /// </summary>
        public void DeleteElement()
        {
            int position;

            if (drawingElements.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("\tDrawing contains no elements, selection ignored.");
                Console.WriteLine("");
                throw new ReturnException();
            }

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Delete element from drawing:");
                Console.WriteLine("");
                Console.Write($"Position (0 .. {drawingElements.Count - 1}, blank == delete last element): ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    position = drawingElements.Count - 1;
                    break;
                }

                if (!int.TryParse(input, out position) || position < 0 || position >= drawingElements.Count)
                {
                    Console.WriteLine("Please supply a valid position.");
                }
            } while (position < 0 || position >= drawingElements.Count);

            drawingElements.RemoveAt(position);
            canvas.Clear();

            foreach (var drawable in drawingElements.OrderBy(e => drawingElements.IndexOf(e)))
            {
                drawable.Draw(canvas);
            }

            throw new ReturnException();
        }

        /// <summary>
        /// Lists the elements in the drawing.
        /// </summary>
        public void ListElements()
        {
            Console.WriteLine("");
            Console.WriteLine("Drawing contains the following elements:");
            Console.WriteLine("");
            Console.WriteLine("Shape");

            foreach (var element in drawingElements)
            {
                string type = element.GetType().Name;
                string x1 = element.Position.X.ToString();
                string y1 = element.Position.Y.ToString();
                string x2 = "";
                string y2 = "";
                string symbol = "";

                switch (element)
                {
                    case Line line:
                        x2 = line.End.X.ToString();
                        y2 = line.End.Y.ToString();
                        symbol = line.Symbol.ToString();
                        break;
                    case Point point:
                        symbol = point.Symbol.ToString();
                        break;
                    case Text label:
                        x2 = (label.Position.X + label.Width - 1).ToString();
                        y2 = (label.Position.Y + label.Height - 1).ToString();
                        symbol = label.LabelText;
                        break;
                }
                if (element is not Point && element is not Text)
                {
                    Console.WriteLine($"{type}\t{x1}\t{y1}\t{x2}\t{y2}\t{symbol}");
                }
                else
                {
                    Console.WriteLine($"{type}\t{x1}\t{y1}\t{symbol}");
                }
            }

            Console.WriteLine("End Shape");

            throw new ReturnException();
        }

        /// <summary>
        /// Gets the position from the user for inserting a new element.
        /// </summary>
        /// <param name="position">The position at which to insert the new element.</param>
        public void GetPosition(out int position)
        {
            if (drawingElements.Count > 0)
            {
                do
                {
                    Console.Write($"Position (0 .. {drawingElements.Count}, blank == after last element): ");
                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        position = drawingElements.Count;
                        break;
                    }

                    if (!int.TryParse(input, out position) || position < 0 || position > drawingElements.Count)
                    {
                        Console.WriteLine("Please supply a valid position.");
                    }
                } while (position < 0 || position > drawingElements.Count);
            }
            else
            {
                position = 0; 
            }
        }
        
        /// <summary>
        /// Gets the canvas associated with the list manager.
        /// </summary>
        /// <returns>The canvas.</returns>
        public Canvas GetCanvas()
        {
            return canvas;
        }

        /// <summary>
        /// Clears the drawing elements and the associated canvas.
        /// </summary>
        public void Clear()
        {
            drawingElements.Clear();
            canvas.Clear();
            drawingChanged = false;
        }

    }