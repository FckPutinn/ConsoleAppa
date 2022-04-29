// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Garen g = new Garen();
g.ctrl3();

RubyCrystal rb = new RubyCrystal();
g.showHP();
g.buyItem(rb);
g.showHP();

LongSword lg = new LongSword();
g.showAD();
g.buyItem(lg);
g.showAD();

class Champion
{
    public string name;
    public float hp;
    public float ad;
    public Item[] items;

    public Champion()
    {
        name = "";
        hp = 0;
        ad = 0;
        items = new Item[6];
        Console.WriteLine("Konstruktor klasy Champion");
    }
    public void buyItem(Item i)
    {
        Console.WriteLine(name.ToString() + " kupuje " + i.name.ToString());
        items[0] = i;
        hp += i.stats["HP"]; 
        items[0] = i;
        ad += i.stats["AD"];
    }
    public void showHP()
    {
        Console.WriteLine("Postać ma " + hp.ToString() + "HP");
    }
    public void showAD()
    {
        Console.WriteLine("Postać ma " + ad.ToString() + "AD");
    }
}
class Garen : Champion
{
    public Garen()
    {
        name = "Garen";
        hp = 620;
        ad = 66;
        Console.WriteLine("Konstruktor klasy Garen");
    }

    public void ctrl3()
    {
        Console.WriteLine("Garen tańczy!");
    }


}

public class Item
{
    public string name;
    public int price;
    public Dictionary<string, float> stats;

    public Item()
    {
        name = "";
        price = 0;
        stats = new Dictionary<string, float>();
        stats.Add("HP", 0);
        stats.Add("AP", 0);
        stats.Add("AD", 0);
    }
}
public class RubyCrystal : Item
{
    public int bonusHP = 150;
    public RubyCrystal()
    {
        name = "Ruby Crystal";
        price = 400;
        stats["HP"] = 150;
    }
}

public class LongSword : Item
{
    public int bonusAD = 10;
    public LongSword()
    {
        name = "Long Sword";
        price = 350;
        stats["AD"] = 10;
    }
}