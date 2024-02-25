using System.Dynamic;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace HW5_L5;

public class PetShop
{
    public string ShopName { get; set; }

    private List<Cat> Cats;
    private List<Dog> Dogs;
    private List<Bird> Birds;
    private List<Fish> Fishes;

    public PetShop(string shopName)
    {
        ShopName = shopName;

        Cats = new List<Cat>();
        Dogs = new List<Dog>();
        Birds = new List<Bird>();
        Fishes = new List<Fish>();
    }

    public bool GetIndex(string name, out string petType, out int index)
    {
        for (int i = 0; i<Dogs.Count; i++)
        {
            if (Dogs[i].Name == name)
            {
                petType="dog";
                index = i;
                return true;
            }
        }
        for (int i = 0; i<Cats.Count; i++)
        {
            if (Cats[i].Name == name)
            {
                petType="cat";
                index = i;
                return true;
            }
        }
        for (int i = 0; i<Birds.Count; i++)
        {
            if (Birds[i].Name == name)
            {
                petType="bird";
                index = i;
                return true;
            }
        }
        for (int i = 0; i<Fishes.Count; i++)
        {
            if (Fishes[i].Name == name)
            {
                petType="fish";
                index = i;
                return true;
            }
        }

        petType="";
        index=-1;
        return false;
    }

    public Dog GetDogByIndex(int index)
    {
        return Dogs[index];
    }
    public Cat GetCatByIndex(int index)
    {
        return Cats[index];
    }
    public Bird GetBirdByIndex(int index)
    {
        return Birds[index];
    }
    public Fish GetFishByIndex(int index)
    {
        return Fishes[index];
    }

    public void RemoveDogByIndex(int index)
    {
        Dogs.RemoveAt(index);
    }
    public void RemoveCatByIndex(int index)
    {
        Cats.RemoveAt(index);
    }
    public void RemoveBirdByIndex(int index)
    {
        Birds.RemoveAt(index);
    }
    public void RemoveFishByIndex(int index)
    {
        Fishes.RemoveAt(index);
    }

    public void AddDog(ref Dog dog)
    {
        Dogs.Add(dog);
    }
    public void AddCat(ref Cat _cat)
    {
        Cats.Add(_cat);
    }
    public void AddBird(ref Bird bird)
    {
        Birds.Add(bird);
    }
    public void AddFish(ref Fish fish)
    {
        Fishes.Add(fish);
    }

    public void ShowAllPets()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\t---  Dogs  ---");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var dog in Dogs) { dog.ShowInfo(); }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------------------------------" +
            "\n\t---  Cats  ---");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var cat in Cats) { cat.ShowInfo(); }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------------------------------" +
            "\n\t---  Fishes  ---");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var fish in Fishes) { fish.ShowInfo(); }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------------------------------" +
            "\n\t---  Birds  ---");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var bird in Birds) { bird.ShowInfo(); }
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void ShowPetsByEnergy(int energy)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\n\t---  Dogs  ---\n");
        Console.ForegroundColor = ConsoleColor.Yellow;

        foreach (var dog in Dogs) { 
            if(dog.Energy >= energy) dog.ShowInfo(); 
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\t---  Cats  ---");
        Console.ForegroundColor = ConsoleColor.Yellow;

        foreach (var cat in Cats) { 
            if (cat.Energy >= energy) cat.ShowInfo();
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\t---  Fishes  ---");
        Console.ForegroundColor = ConsoleColor.Yellow;

        foreach (var fish in Fishes) { 
            if (fish.Energy >= energy) fish.ShowInfo();
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\t---  Birds  ---");
        Console.ForegroundColor = ConsoleColor.Yellow;

        foreach (var bird in Birds) {
            if (bird.Energy >= energy) bird.ShowInfo();
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public int GetTotalPetCount()
    {
        return (Cats.Count+ Birds.Count+ Fishes.Count+Dogs.Count);
    }

    public long GetTotalPetPrice()
    {
        long price = 0;

        foreach (var dog in Dogs) { price+=dog.Price; }
        foreach (var cat in Cats) { price+=cat.Price; }
        foreach (var fish in Fishes) { price+=fish.Price; }
        foreach (var bird in Birds) { price+=bird.Price; }

        return price;
    }

}

