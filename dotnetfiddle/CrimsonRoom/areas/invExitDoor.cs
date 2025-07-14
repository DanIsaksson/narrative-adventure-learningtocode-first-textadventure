using System;

public static class invExitDoor
{
    public static void exitDoorInvestigate()
    {
        Console.WriteLine("You're facing the main door, the only visible way out of this crimson room. It's a heavy, reinforced steel door with multiple locks. A small slot is set at eye level.");

        switch(Console.ReadLine())
        {
            case "Knob":
                Console.WriteLine("You grab the doorknob and try to turn it. It doesn't budge. It feels solid, unmoving, and cold as ice.");
                break;
            
            case "Locks":
                Console.WriteLine("You examine the locks. There are three of them: a standard keyhole, a combination lock, and a strange electronic keypad that isn't powered on.");
                break;

            case "Slot":
                Console.WriteLine("You peer through the small slot. You can't see anything but another, identical door just a few feet away. This is a small airlock, not an exit.");
                break;

            case "Nothing":
                Console.WriteLine("You stare at the door, the feeling of being trapped sinking in.");
                break;
        }
    }
}