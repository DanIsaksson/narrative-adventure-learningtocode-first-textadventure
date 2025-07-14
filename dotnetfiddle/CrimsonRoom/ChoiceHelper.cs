using System;

public static class ChoiceHelper
{
    /// <summary>
    /// Shows the A–H menu, reads the user's choice and returns the next GameState.
    /// Passing in originalState lets "H" return you to wherever you called from.
    /// </summary>
    public static GameState GetNextState(GameState originalState)
    {
        while (true)
        {
            // C#11 raw string literal — no escaping needed
            Console.WriteLine("""
            "So... hehe... what to do..?"
            It's that voice again. You feel an urge to inspect something.

            The room is filled with old furniture and antique looking objects. 

            Enter the letter of your choice. Do you inspect the...
            A) ... bed?
            B) ... drawer?
            C) ... window?
            D) ... closet?
            E) ... mirror?
            F) ... clock?
            G) ... door?
            H) ... nothing?
            """);

            string? inspectChoice = Console.ReadLine()?.ToUpper();
            switch (inspectChoice)
            {
                case "A": return GameState.eBed;
                case "B": return GameState.eDrawer;
                case "C": return GameState.eWindow;
                case "D": return GameState.eCloset;
                case "E": return GameState.eMirror;
                case "F": return GameState.eClock;
                case "G": return GameState.eExitDoor;
                case "H":
                    Console.WriteLine("""
                    "Scared are we? Hehe... I have all day... year even."
                    """);
                    return originalState;    // jump back to where we started
                
                default:
                    Console.WriteLine("Haha, very funny... Try again.");
                    break;
            }
        }
    }
} 