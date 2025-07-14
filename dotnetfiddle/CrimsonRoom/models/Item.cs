public abstract class Item
{
    public string? Name;
    public string? Description;
}

public abstract class  PassiveItem : Item 
{       
     public string effect;

}


public abstract class ToUseItem : Item
{
     public  Use(Player player)
    {

    }
}

public  class HealingItem : Item
{
    public HealingItem(string Name, string Description, int HealAmount)
    {
        this.Name = Name;
        this.Description = Description;
        this.HealAmount = HealAmount;
    }

    public void Use(Player player)
    {
        this.Name = Name;
        this.HealAmount = HealAmount;
        
        player.Health += HealAmount;
    }

} 