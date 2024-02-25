namespace HW5_L5;

public class Bird : Animal
{
    public bool CanFly { get; set; } // ucha bilen qushdur?

    public Bird(string name, string gender, int age, int energy, int price, int mealQuantity, bool canFly)
       : base(name, gender, age, energy, price, mealQuantity)
    {
        CanFly=canFly;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        if (CanFly) Console.WriteLine($"Bird Can Fly? : Yes");
        else Console.WriteLine($"Bird Can Fly? : No");
    }

    public override string ToString()
    {
        this.ShowInfo(); return "";
    }
}

