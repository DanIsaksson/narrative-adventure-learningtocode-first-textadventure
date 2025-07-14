using System;

public static class invDrawer
{
    public static void drawerInvestigate(Player thePlayer)
    {
        Console.WriteLine("There's a small, unassuming wooden drawer set into a nearby desk. It looks like it hasn't been opened in years, covered in a thick layer of dust.");
        while(true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Open Drawer");
            Console.WriteLine("2. Dust");
            Console.WriteLine("3. Nothing");
            Console.WriteLine("4. Check other parts of the room");
            
            switch(Console.ReadLine()?.ToUpper())
            {
                case "1":
                    Console.WriteLine("You tug at the handle. It's stuck. With a sharp pull, it jerks open with a loud crack. Inside, you find a small flask with a red liquid inside. It's labeled 'Small Potion'.");
                    thePlayer.Inventory.Add(new HealingItem("Small Potion", "A small flask with a red liquid inside. It's labeled 'Small Potion'.", 20));               
                    break;
                case "2":
                    Console.WriteLine("You wipe away the dust on top of the drawer. Underneath, you find a small, carved symbol, a circle with a cross through it. It seems familiar, but you can't place it.");
                    break;

                case "3":
                    Console.WriteLine("It's just a drawer. You leave it be.");
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Darn it, nothing? Try again.");
                    break;
            }
            
        }
    }
}