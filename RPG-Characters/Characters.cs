namespace RPG_Characters;

public class Characters
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Weapon EquippedWeapon { get; set; }

    public Characters(string name, string description)
    {
        Name = name;
        Description = description;
    }


    public virtual void Attack()
    {
        if (EquippedWeapon is not null)
        {
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("");
        }
    }

    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
        Console.WriteLine($"{Name} has equipped {weapon.Description}");
    }
}