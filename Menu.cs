namespace A2_n11479752;

using System;

/// <summary>
/// Represents a menu with a collection of menu items.
/// </summary>
public class Menu : MenuItem
{
    private readonly MenuItem[] items;
    private Menu mainMenu;
    private const string CurrentDrawingName = "UnnamedDrawing.txt";

    /// <summary>
    /// Initializes a new instance of the Menu class.
    /// </summary>
    /// <param name="title">The title of the menu.</param>
    /// <param name="items">The menu items contained within the menu.</param>
    public Menu(string title, params MenuItem[] items) : base(title)
    {
        this.items = items;
        this.mainMenu = this;
    }

    public override void Action()
    {
        base.Action();
        DisplayMenu();
        HandleUserInput();
    }

    /// <summary>
    /// Perform the action associated with the menu.
    /// </summary>
    private void DisplayMenu()
    {
        if (mainMenu == this && !Title.TrimStart().ToLower().StartsWith("edit"))
        {
            Console.WriteLine(Title);
            Console.WriteLine("");
        }

        if (mainMenu == this &&
            (Title.TrimStart().ToLower().StartsWith("edit") || Title.TrimStart().ToLower() == "edit"))
        {
            Console.WriteLine("");
            Console.WriteLine($"Editing drawing {CurrentDrawingName}");
            Console.WriteLine("");
        }

        foreach (var item in items)
        {
            Console.WriteLine(item.Title);
        }
    }

    /// <summary>
    /// Handle the user input for menu navigation.
    /// </summary>
    /// <exception cref="ReturnException"></exception>
    private void HandleUserInput()
    {
        Console.Write("? ");
        string? userChoice = Console.ReadLine()?.Trim().ToLower();

        if (userChoice == "return")
        {
            Console.WriteLine("");
            throw new ReturnException();
        }

        bool validOptionSelected = false;

        foreach (var item in items)
        {
            if (userChoice != item.Title.Split(" ")[0].ToLower()) continue;
            try
            {
                item.Action();
            }
            catch (ReturnException)
            {
                mainMenu.Action();
            }

            validOptionSelected = true;
            break;
        }

        if (validOptionSelected) return;
        
        if (mainMenu == this && !Title.ToLower().Contains("edit"))
        {
            Console.WriteLine("\tInvalid option, try again");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("\tInvalid option, please try again");
        }
        DisplayMenu();
        HandleUserInput();
    }
}