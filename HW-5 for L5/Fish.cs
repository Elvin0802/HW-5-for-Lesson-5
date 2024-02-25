namespace HW5_L5;

public class Fish : Animal
{
    public bool IsMammal { get; set; } // baligin novu

    public Fish(string name, string gender, int age, int energy, int price, int mealQuantity,bool isMammal)
       : base(name, gender, age, energy, price, mealQuantity)
    {
        IsMammal=isMammal;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        if (IsMammal) Console.WriteLine($"Fish is Mammal? : Yes");
        else Console.WriteLine($"Fish is Mammal? : No");
    }

    public override string ToString()
    {
        this.ShowInfo();return "";
    }
}

