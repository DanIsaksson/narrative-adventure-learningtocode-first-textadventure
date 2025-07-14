using System;

public static class gameQuit
{
    public static void QuitGame()
    {
        Console.WriteLine("Are you sure you want to quit? (Y/N)");
        string confirm = Console.ReadLine() ?? "";

        if (confirm.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("... a part of you will always remain in the crimson room.");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("There is no escape.");
        }
    }
}