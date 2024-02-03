namespace RPG_Characters;

public class Card_Thrower : Characters
{
    public Card_Thrower(string name, string description) : base(name, description)
    {
    }

    public override void Attack()
    {
        if (EquippedWeapon is not null)
        {
            Console.WriteLine(
                $"{Name} attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}, dealing {EquippedWeapon.Damage} damage ..");
        }
        else
        {
            Console.WriteLine(
                $"{Name} attack with their bare fists .. dealing minimal damage. I recommend you equip a weapon, traveller.");
        }
    }
}