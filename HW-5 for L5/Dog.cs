namespace HW5_L5;

public class Dog : Animal
{
    public bool IsWild { get; set; }// quduz olub olmamagi


    public Dog(string name, string gender, int age, int energy, int price, int mealQuantity, bool isWild)
        : base(name, gender, age, energy, price, mealQuantity)
    {
        IsWild=isWild;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        if (IsWild) Console.WriteLine($"Dog is Wild? : Yes");
        else Console.WriteLine($"Dog is Wild? : No");
    }

    public override string ToString()
    {
        this.ShowInfo(); return "";
    }
}
