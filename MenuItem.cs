namespace A2_n11479752;

using System;

/// <summary>
/// Represents a menu item with a title and an associated action.
/// </summary>
public class MenuItem
{
    private string title;
    private readonly Action action;

    /// <summary>
    /// Get the title of the menu item.
    /// </summary>
    public string Title
    {
        get => title;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException();
            }

            title = value;
        }
    }

    /// <summary>
    /// Initialize a new instance of the MenuItem class.
    /// </summary>
    /// <param name="title">The title of the menu item.</param>
    /// <param name="action">The action associated with the menu item
    /// (default is an empty action)</param>
    public MenuItem(string title, Action action = null)
    {
        Title = title;
        if (action == null) action = () => { };
        this.action = action;
    }

    public virtual void Action()
    {
        action();
    }
}