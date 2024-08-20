using System.Text;

namespace A2_n11479752;

/// <summary>
/// Provides methods for checking and obtaining user input.
/// </summary>
public abstract class CheckInput
{
    /// <summary>
    /// Gets integer coordinates from the user.
    /// </summary>
    /// <param name="prompt">The prompt message to display.</param>
    /// <param name="value">The output variable to store the entered value.</param>
    public static void GetCoordinates(string prompt, out int value)
    {
        while (true)
        {
            Console.Write(prompt);

            if (int.TryParse(Console.ReadLine(), out value))
            {
                break;
            }

            Console.WriteLine("Please supply a whole number.");
        }
    }

    /// <summary>
    /// Gets a valid ASCII character symbol from the user.
    /// </summary>
    /// <returns>The entered symbol.</returns>
    public static char GetSymbol()
    {
        char symbol;
        do
        {
            Console.Write("Symbol: ");
            var input = Console.ReadLine()?.Trim();

            symbol = input?.Length > 0 ? input[0] : ' ';

            if (!char.IsAscii(symbol) || char.IsWhiteSpace(symbol))
            {
                Console.WriteLine("Please supply a character between '!' and '~'");
            }
        } while (!char.IsAscii(symbol) || char.IsWhiteSpace(symbol));

        return symbol;
    }

    /// <summary>
    /// Gets a valid non-empty text label from the user.
    /// </summary>
    /// <returns>The entered text label.</returns>
    public static string GetLabel()
    {
        string text;
        do
        {
            Console.Write("Text: ");
            var input = Console.ReadLine();

            text = CheckText(input);

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Please enter valid text.");
            }
        } while (string.IsNullOrWhiteSpace(text));

        return text;
    }
    
    /// <summary>
    /// Checks and cleans up the input text, removing control characters.
    /// </summary>
    /// <param name="input">The input text to be checked.</param>
    /// <returns>The cleaned-up text.</returns>
    private static string CheckText(string? input)
    {
        var checkedText = new StringBuilder();

        if (input == null) return checkedText.ToString();
        foreach (var c in input)
        {
            if (char.IsControl(c) && !char.IsWhiteSpace(c))
            {
                checkedText.Append(' ');
            }
            else
            {
                checkedText.Append(c);
            }
        }
        return checkedText.ToString();
    }
}