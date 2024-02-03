namespace RPG_Characters;

public class Characters
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Characters(string name, string description)
    {
        Name = name;
        Description = description;
    }


    public virtual void Attack()
    {
        Console.WriteLine($"{Name} attacks with their weapon!");
    }
}