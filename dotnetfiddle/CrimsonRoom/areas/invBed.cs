using System;

public static class invBed
{
     public static void bedInvestigate()  // This is the method that will be called when the player chooses to investigate the bed.
     {
          Console.WriteLine(
               """
               The bed is worn, and jarringly you notice a large spot of red stains. There's also an old blanket, it's dusty with old food smudges on it. 
               What do you do?
              
               A) Pick up the blanket and inspect it.
               B) Inspect the blood stains.
               C) Inspect another part of the room.
               """
               );
          
          string? bedChoice = Console.ReadLine();
          switch(Console.ReadLine())
          {
          case "Blanket":
          Console.WriteLine("You walk over to the bed and sit down.");
          break;

          case "Blood":
          Console.WriteLine("As you lean in, you smell the stench. It's blood alright. And lots of it... you can see a blood trail leading out from the bed.");
          break;

          default:
          Console.WriteLine("You turn around towards the rest of the room again..");
          break;
          }
     }
}