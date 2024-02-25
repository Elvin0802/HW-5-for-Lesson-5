namespace HW5_L5;

public abstract class Animal
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }
    public int Energy { get; set; }
    public int Price { get; set; }
    public int MealQuantity { get; set; }

    public Animal(string name, string gender, int age)
    {
        Name = name; Gender = gender; Age=age;
        Energy = 0; Price = 0; MealQuantity = 0;
    }
    public Animal(string name, string gender, int age, int energy, int price, int mealQuantity)
        : this(name, gender, age)
    {
        Energy = energy; Price = price; MealQuantity = mealQuantity;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nGender: {Gender}\nAge: {Age}" +
            $"\nEnergy: {Energy}\nPrice: {Price}\nMealQuantity: {MealQuantity}");
    }

    public void Eat()
    {
        if (MealQuantity > 0)
        {
            MealQuantity--;
            Price++;
        }
    }

    public virtual void Sleep()
    {
        Energy++;
    }

    public virtual void Play()
    {
        Energy--;

        if (Energy <= 0)
        {
            Sleep();

            Console.WriteLine("\nPet Sleeping ...");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\t\tPress any key to Continue ....");
            Console.ForegroundColor = ConsoleColor.White;
            _ = Console.ReadKey();
        }
    }
}
