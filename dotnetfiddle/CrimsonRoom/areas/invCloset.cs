using System;

public static class invCloset
{
    public static void closetInvestigate()
    {
        Console.WriteLine("You approach a large wooden closet. The door is slightly ajar, revealing a pitch-black interior. A strange, musty smell emanates from it, a mix of old clothes and something... metallic.");

        switch(Console.ReadLine())
        {
            case "Open Door":
                Console.WriteLine("You slowly pull the door open. A single, tattered coat hangs inside. As the door opens fully, you see scratch marks all over the interior walls.");
                break;

            case "Smell":
                Console.WriteLine("You lean in, taking a cautious sniff. The metallic smell is stronger now. It's unmistakably the scent of old, dried blood.");
                break;

            case "Nothing":
                Console.WriteLine("Probably best not to disturb whatever is in there. You back away.");
                break;
        }
    }
}