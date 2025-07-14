using System;

public static class invMirror
{
    public static void mirrorInvestigate()
    {
        Console.WriteLine("A large, ornate mirror hangs on the wall. Its surface is grimy, but you can still make out your own reflection. You look tired, scared. For a moment, you think you see something move behind you in the reflection.");

        switch(Console.ReadLine())
        {
            case "Clean Mirror":
                Console.WriteLine("You wipe a patch of grime off the mirror. Your reflection becomes clearer, but as you stare into your own eyes, they seem to darken, and for a split second, your reflection smiles when you don't.");
                break;

            case "Look Behind":
                Console.WriteLine("You whip around, but there's nothing there. Just the empty, silent room. You turn back to the mirror, and the feeling of being watched intensifies.");
                break;

            case "Nothing":
                Console.WriteLine("You can't stand to look at yourself, or what might be with you, any longer. You turn away.");
                break;
        }
    }
}