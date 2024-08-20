namespace A2_n11479752;

using System;

/// <summary>
/// Canvas class encapsulates a drawing surface which provides low-level 
/// support to render lines, points and texts using character-based graphics.
/// </summary>
public class Canvas
{
    private int width;
    private int height;
    private char[,] cells;

    /// <summary>
    /// Get the canvas's width.
    /// </summary>
    /// <value>
    /// The width of the canvas which is a positive integer.
    /// </value>
    /// <exception cref="ArgumentException">
    /// ArgumentException is thrown if value is less than or equal to zero.
    /// </exception>
    private int Width {
        get => width;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width must be greater than zero.");
            }

            width = value;
        }
    }

    /// <summary>
    /// Get the canvas's height.
    /// </summary>
    /// <value>
    /// The height of the canvas which is a positive integer.
    /// </value>
    /// <exception cref="ArgumentException">
    /// ArgumentException is thrown if value is less than or equal to zero.
    /// </exception>
    private int Height {
        get => height;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height must be greater than zero.");
            }

            height = value;
        }
    }

    /// <summary>
    /// Initialise the canvas.
    /// </summary>
    /// <param name="width">The width of the canvas which is a positive integer.</param>
    /// <param name="height">The height of the canvas which is a positive integer.</param>
    public Canvas(int width = 80, int height = 28) 
    {
        Width = width;
        Height = height;
        cells = new char[height, width];
        Clear();
    }

    /// <summary>
    /// Erase contents of canvas to replace it with spaces.
    /// </summary>
    public void Clear() 
    {
        for (var row = 0; row < Height; row++)
        {
            for (var column = 0; column < Width; column++)
            {
                cells[row, column] = ' ';
            }
        }
    }

    /// <summary>
    /// Render the canvas to the standard output stream.
    /// </summary>
    public void Show() 
    {
        for (var row = 0; row < Height; row++)
        {
            for (var column = 0; column < Width; column++)
            {
                Console.Write(cells[row, column]);
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Sets the contents of a cell to a given value.
    /// Canvas is unaffected if row or column is out of bounds.
    /// All other cells in the canvas are unchanged apart from the affected cell.
    /// </summary>
    /// <param name="row">
    /// An integer which is the row of the cell affected if within bounds.
    /// </param>
    /// <param name="column">
    /// An integer which is the column of the cell affected if within bounds.
    /// </param>
    /// <param name="c">
    /// The symbol to render in the specified cell.
    /// </param>
    public void Draw(int row, int column, char c) 
    {
        if (row < 0 || row >= Height || column < 0 || column >= Width) return;

        cells[row, column] = c;
    }

    /// <summary>
    /// Adds a single line of text to the canvas, starting at the stipulated location.
    /// characters that fall within the bounds of the display are rendered.
    /// </summary>
    /// <param name="row">The row where the first character will be displayed.</param>
    /// <param name="column">The column in where the first character will be displayed.</param>
    /// <param name="s">The non-null text to be added.</param>
    public void Draw(int row, int column, string s) 
    {
        for (var i = 0; i < s.Length; i++)
            Draw(row, column + i, s[i]);
    }

    /// <summary>
    /// Utility method to swap the values of two integer variables.
    /// </summary>
    /// <param name="a">One value.</param>
    /// <param name="b">The other value.</param>
    private static void SwapInt(ref int a, ref int b) 
    {
        (a, b) = (b, a);
    }

    /// <summary>
    /// Adds a line to the canvas. Points falling out of bounds
    /// are ignored.
    /// </summary>
    /// <param name="y0">The row where the line starts.</param>
    /// <param name="x0">The column where the line starts.</param>
    /// <param name="y1">The row where the line ends.</param>
    /// <param name="x1">The column where the line ends.</param>
    /// <param name="symbol">The symbol used to render the line.</param>
    public void Draw(int y0, int x0, int y1, int x1, char symbol) 
    {
        double dx = (x1 - x0);
        double dy = (y1 - y0);
        double adx = Math.Abs(x1 - x0);
        double ady = Math.Abs(y1 - y0);

        if (adx >= ady)
        {
            if (x0 > x1)
            {
                SwapInt(ref x0, ref x1);
                SwapInt(ref y0, ref y1);
                dx = -dx;
                dy = -dy;
            }

            for (int x = x0; x <= x1; x++)
            {
                var y = (x - x0) * dy / dx + y0;
                Draw((int)Math.Round(y), x, symbol);
            }
        }
        else
        {
            if (y0 > y1)
            {
                SwapInt(ref x0, ref x1);
                SwapInt(ref y0, ref y1);
                dx = -dx;
                dy = -dy;
            }

            for (int y = y0; y <= y1; y++)
            {
                var x = (y - y0) * dx / dy + x0;
                Draw(y, (int)Math.Round(x), symbol);
            }

        }
    }
}