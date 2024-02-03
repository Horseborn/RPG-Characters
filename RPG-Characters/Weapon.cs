namespace RPG_Characters;

public class Weapon
{
    public string Description { get; set; }
    public string AttackMessage { get; set; }
    public int Damage { get; set; }
    public string AttackType { get; set; }

    public Weapon(string description, string attackMessage, int damage, string attackType)
    {
        Description = description;
        AttackMessage = attackMessage;
        Damage = damage;
        AttackType = attackType;
    }
    
}