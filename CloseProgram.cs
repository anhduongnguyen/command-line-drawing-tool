namespace A2_n11479752;

using System;

/// <summary>
/// Represents a menu item which terminates the program gracefully.
/// </summary>
public class CloseProgram : MenuItem
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CloseProgram"/>; class with the specified title.
    /// </summary>
    /// <param name="title">The title of the menu item.</param>
    public CloseProgram(string title) : base(title) { }
    
    /// <summary>
    /// Perform the action associated with terminating the program.
    /// </summary>
    public override void Action()
    {
        Console.WriteLine("");
        Console.WriteLine("Goodbye and thank you for using our service.");
    }
}