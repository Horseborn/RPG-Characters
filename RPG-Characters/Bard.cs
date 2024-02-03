namespace RPG_Characters;

public class Bard : Characters
{
    public Bard(string name, string description) : base (name, description)
    {
        
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} the Bard is attacking!");
    }
}