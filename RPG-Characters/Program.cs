namespace RPG_Characters;

class Program
{
    static void Main(string[] args)
    {
        Trash sebastian = new Trash("Sebastian", 26);
        Console.WriteLine($"Meine name ist {sebastian.Name} und ich bin {sebastian.Age}");


        Bard bebe = new Bard("Prayer", "Cool d00d");
        bebe.Attack();
        Console.WriteLine($"His name was {bebe.Name} and he was {bebe.Description}");
    }
}

class Trash
{
    public string Name { get; private set; }
    public int Age { get; private set; }


    public Trash(string name, int age)
    {
        Name = name;
        Age = age;
    }
}