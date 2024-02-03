namespace RPG_Characters;

class Program
{
    static void Main(string[] args)
    {
        Card_Thrower cardThrower = new Card_Thrower("gambit", "mega nice thrower");
        Weapon cards = new Cards();
        cardThrower.EquipWeapon(cards);
        cardThrower.Attack();

        Fjøsnisse fjøsnisse = new Fjøsnisse("Jørn", "Curd Mage");
        Cheese_Wheel_Shield shield = new Cheese_Wheel_Shield();
        fjøsnisse.EquipWeapon(shield);
        fjøsnisse.Attack();
    }
}


