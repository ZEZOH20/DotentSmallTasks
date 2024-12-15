using System;

public class Program
{
    public static void Main()
    {
        Bird nonFlyingBird = new NonFlyingBird();
        Bird flyingBird = new FlyingBird();

        nonFlyingBird.StartFly(); // Output: "NonFlyingBird: Shared fly behavior."
        flyingBird.StartFly();    // Output: "FlyingBird: Shared fly behavior."
    }
}

// Implement the base class for shared behavior
public abstract class Bird
{
    public string Name { get; protected set; } = string.Empty;

    // Shared implementation of StartFly
    public virtual void StartFly()
    {
        Console.WriteLine($"{Name}: Shared fly behavior.");
    }
}

// Implement the class for non-flying birds
public class NonFlyingBird : Bird
{
    public NonFlyingBird()
    {
        Name = "NonFlyingBird";
    }
}

// Implement the class for flying birds
public class FlyingBird : Bird
{
    public FlyingBird()
    {
        Name = "FlyingBird";
    }
}
