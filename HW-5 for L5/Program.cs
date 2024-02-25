using HW5_L5;


string[] category = { "Dog", "Cat", "Fish", "Bird" };

string[] menu = { "Add New Pet", "Show All Pets Info","Show Pet Info By Name", "Remove Pet By Name",
    "Send Pet To Eat By Name","Send Pet To Sleep By Name", "Show Total Eaten Food Count",
    "Show Total Price of Pets", "Show Pets. if entered value <= Pet Energy", "Exit" };


int opt = 0, totalEatenFood = 0;

PetShop petShop = new("MyPetShop");

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n\t\t~~~~~~  Welcome The PetShop  ~~~~~~\n\n");
    Console.ForegroundColor = ConsoleColor.White;

    for (int k = 0; k < menu.Length; k++)
    {
        if (opt == k)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\t\t\t{k+1} ) {menu[k]}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.WriteLine($"\t\t\t{k + 1} ) {menu[k]}");
        }
    }

    if (KeyCheck(ref opt, 0, (menu.Length-1)))
    {
        if (opt == menu.Length-1)
        {
            Thread.Sleep(500);
            break;
        }

        if (opt == 0)
        {
            int opt2 = 0;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < category.Length; i++)
                {
                    if (opt2 == i)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\t\t\t{i+1} - {category[i]}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine($"\t\t\t{i+1} - {category[i]}");
                    }
                }

                if (KeyCheck(ref opt2, 0, (category.Length-1)))
                {
                    Console.Clear();
                    
                    string? n = "", g = "";
                    int a = 0, e = 0, p = 0, mq = 0;

                    Console.WriteLine("\n\t\t\tNew Pet Adding.");


                    Console.Write("\n\tEnter a Name : ");
                    n=Console.ReadLine();

                    Console.Write("\n\tEnter a Gender : ");
                    g=Console.ReadLine();

                    Console.Write("\n\tEnter a Age : ");
                    a=int.Parse(Console.ReadLine());

                    Console.Write("\n\tEnter a Energy : ");
                    e=int.Parse(Console.ReadLine());

                    Console.Write("\n\tEnter a Price : ");
                    p=int.Parse(Console.ReadLine());

                    Console.Write("\n\tEnter a Meal Quantity : ");
                    mq=int.Parse(Console.ReadLine());

                    if (opt2 == 0)
                    {
                        bool iw = false;

                        Console.Write("\n\tEnter a Dog is Wild? (1 or 0) : ");
                        string t = Console.ReadLine();

                        if (t=="1") { iw = true; }

                        Dog d = new(n, g, a, e, p, mq, iw);
                        petShop.AddDog(ref d);
                    }
                    else if (opt2 == 1)
                    {
                        bool inv = false;

                        Console.Write("\n\tEnter a Cat is Have Night Vision? (1 or 0) : ");
                        string t = Console.ReadLine();

                        if (t=="1") { inv = true; }

                        Cat c = new(n, g, a, e, p, mq, inv);
                        petShop.AddCat(ref c);
                    }
                    else if (opt2 == 2)
                    {
                        bool im = false;

                        Console.Write("\n\tEnter a Fish is Mammal? (1 or 0) : ");
                        string t = Console.ReadLine();

                        if (t=="1") { im = true; }

                        Fish f = new(n, g, a, e, p, mq, im);
                        petShop.AddFish(ref f);
                    }
                    else if (opt2 == 3)
                    {
                        bool cf = false;

                        Console.Write("\n\tEnter a Bird Can Fly? (1 or 0) : ");
                        string t = Console.ReadLine();

                        if (t=="1")
                        {
                            cf = true;
                        }

                        Bird b = new(n, g, a, e, p, mq, cf);
                        petShop.AddBird(ref b);
                    }

                    Console.WriteLine("\n\n\t\tPet Successfully Added.");
                    Pause();
                    break;
                }
            }
        }
        else if (opt == 1)
        {
            petShop.ShowAllPets();
            Pause();
        }
        else if (opt == 2)
        {
            string name;

            Console.WriteLine("\tEnter a Name : ");
            name = Console.ReadLine();

            int index; string type;

            if (!(petShop.GetIndex(name, out type, out index)))
            {
                Console.WriteLine("\n\n\t\tPet Don't Find !");
                Pause();
                continue;
            }

            if (type=="") { Console.WriteLine("\n\n\t\tPet Don't Find !"); }
            else if (type=="dog") { petShop.GetDogByIndex(index).ShowInfo(); }
            else if (type=="cat") { petShop.GetCatByIndex(index).ShowInfo(); }
            else if (type=="bird") { petShop.GetBirdByIndex(index).ShowInfo(); }
            else if (type=="fish") { petShop.GetFishByIndex(index).ShowInfo(); }

            Pause();
        }
        else if (opt == 3)
        {
            string name;

            Console.WriteLine("\tEnter a Name : ");
            name = Console.ReadLine();

            int index; string type;

            if (!(petShop.GetIndex(name, out type, out index)))
            {
                Console.WriteLine("\n\n\t\tPet Don't Find !");
                Pause();
                continue;
            }

            if (type=="") { Console.WriteLine("\n\n\t\tPet Don't Find !"); }
            else if (type=="dog") { petShop.RemoveDogByIndex(index); }
            else if (type=="cat") { petShop.RemoveCatByIndex(index); }
            else if (type=="bird") { petShop.RemoveDogByIndex(index); }
            else if (type=="fish") { petShop.RemoveDogByIndex(index); }

            Console.WriteLine("\n\n\t\tPet Successfully Removed.");
            Pause();
        }
        else if (opt == 4)
        {
            string? name;

            Console.WriteLine("\tEnter a Name : ");
            name = Console.ReadLine();

            int index; string type;

            if (!(petShop.GetIndex(name, out type, out index)))
            {
                Console.WriteLine("\n\n\t\tPet Don't Find !");
                Pause();
                continue;
            }

            if (type=="") { Console.WriteLine("\n\n\t\tPet Don't Find !"); }
            else if (type=="dog") { petShop.GetDogByIndex(index).Eat(); }
            else if (type=="cat") { petShop.GetCatByIndex(index).Eat(); }
            else if (type=="bird") { petShop.GetBirdByIndex(index).Eat(); }
            else if (type=="fish") { petShop.GetFishByIndex(index).Eat(); }
            totalEatenFood++;

            Console.WriteLine("\n\n\t\tPet Eating ...");
            Pause();
        }
        else if (opt == 5)
        {
            string? name;

            Console.WriteLine("\tEnter a Name : ");
            name = Console.ReadLine();

            int index; string type;

            if (!(petShop.GetIndex(name, out type, out index)))
            {
                Console.WriteLine("\n\n\t\tPet Don't Find !");
                Pause();
                continue;
            }

            if (type=="") { Console.WriteLine("\n\n\t\tPet Don't Find !"); }
            else if (type=="dog") { petShop.GetDogByIndex(index).Sleep(); }
            else if (type=="cat") { petShop.GetCatByIndex(index).Sleep(); }
            else if (type=="bird") { petShop.GetBirdByIndex(index).Sleep(); }
            else if (type=="fish") { petShop.GetFishByIndex(index).Sleep(); }

            Console.WriteLine("\n\n\t\tPet Sleeping ...");
            Pause();
        }
        else if (opt == 6)
        {
            Console.WriteLine($"\n\n\t\tTotal Eaten Food Count : {totalEatenFood} .");
            Pause();
        }
        else if (opt == 7)
        {
            Console.WriteLine($"\n\n\t\tTotal Pet Price : {petShop.GetTotalPetPrice()} $");
            Pause();
        }
        else if (opt == 8)
        {
            int value = 0;
            Console.WriteLine("\tEnter a Energy Value : ");
            value = int.Parse(Console.ReadLine());

            if (value < 1)
            {
                Console.WriteLine("\n\n\t\tThe Entered Value must be Positive !");
                Pause();
                continue;
            }

            petShop.ShowPetsByEnergy(value);
        }
        else if (opt == 9)
        {
            Console.WriteLine("\n\n\t\tExiting...");
            Thread.Sleep(1099);
            return;
        }
    }
}


bool KeyCheck(ref int option, int min, int max)
{
    ConsoleKeyInfo key = Console.ReadKey(true);

    if (key.Key == ConsoleKey.Enter)
    {
        return true;
    }
    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W ||
        key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
    {
        option--;
        if (option < min) option = max;
    }
    else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S ||
        key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
    {
        option++;
        if (option > max) option = min;
    }

    return false;
}

void Pause()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\n\n\t\tPress any key to Continue ....");
    Console.ForegroundColor = ConsoleColor.White;
    _ = Console.ReadKey();
}