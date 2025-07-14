using System;

public static class invClock
{
    public static void clockInvestigate()
    {
        Console.WriteLine("A tall, ominous grandfather clock stands in the corner. It's silent, its pendulum still. The time is stopped at 3:33.");

        switch(Console.ReadLine())
        {
            case "Hands":
                Console.WriteLine("You try to move the clock hands, but they are stuck fast. A faint scratching sound comes from within the clock's body.");
                break;

            case "Pendulum":
                Console.WriteLine("You reach for the pendulum. It's surprisingly cold. As you touch it, you feel a slight vibration, as if something just moved inside.");
                break;

            case "Nothing":
                Console.WriteLine("You decide to leave the clock alone for now.");
                break;
        }
    }
}