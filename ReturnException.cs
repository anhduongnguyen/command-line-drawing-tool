namespace A2_n11479752;

using System;

/// <summary>
/// Represents an exception used to signal a return action in the program.
/// </summary>
public class ReturnException : Exception
{
    /// <summary>
    /// Initialize a new instance of the <see cref="ReturnException"/>  class.
    /// </summary>
    public ReturnException() : base("Return exception") { }
}