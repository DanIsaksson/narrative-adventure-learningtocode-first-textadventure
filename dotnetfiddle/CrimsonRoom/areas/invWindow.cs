using System;

public static class invWindow
{
    public static void windowInvestigate()
    {
        Console.WriteLine("There is a single, large window on the far wall. It’s covered by thick, heavy curtains. No light seems to be coming through.");

        switch(Console.ReadLine())
        {
            case "Curtains":
                Console.WriteLine("You pull back the heavy curtains. It's not a window. It's a solid brick wall. Someone has painted a realistic window on the bricks. A cruel joke.");
                break;

            case "Feel":
                Console.WriteLine("You press your hand against the curtain. It's cold, and you feel a draft. There must be a hole in the wall behind it somewhere.");
                break;

            case "Nothing":
                Console.WriteLine("Whatever is, or isn't, behind the curtain can wait. You leave it alone.");
                break;
        }
    }
}