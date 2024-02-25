namespace HW5_L5;

public class Cat : Animal
{
    public bool IsHaveNightVision { get; set; }// gece gorme qabiliyeti var?

    public Cat(string name, string gender, int age, int energy, int price, int mealQuantity, bool isHaveNightVision)
        : base(name, gender, age, energy, price, mealQuantity)
    {
        IsHaveNightVision=isHaveNightVision;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        if (IsHaveNightVision) Console.WriteLine($"Cat is Have Night Vision? : Yes");
        else Console.WriteLine($"Cat is Have Night Vision? : No");
    }
    public override string ToString()
    {
        this.ShowInfo(); return "";
    }
}

