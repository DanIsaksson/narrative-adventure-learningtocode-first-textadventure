public abstract class Character
{
public string? Name;
public int Health;
public List<Item> Inventory {get; set;}

    // The base constructor
    public Character(string? name, int health)
    {
        this.Name = name;
        this.Health = health;
        this.Inventory = new List<Item>();
    }
}

public class Player : Character
{
     public Player(string? name, int health) : base(name, health)
     {}

}


public class NPC : Character
{
     public NPC(string? name, int health) : base(name, health)
     {}
}