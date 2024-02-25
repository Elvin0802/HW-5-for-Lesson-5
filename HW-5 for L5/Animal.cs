namespace HW5_L5;

public abstract class Animal
{
	public string? Name { get; set; }
	public int Age { get; set; }
	public string? Gender { get; set; }
	public int Energy { get; set; }
	public int Price { get; set; }
	public int MealQuantity { get; set; }

	public Animal(string name,string gender,int age)
	{
		Name = name; Gender = gender; Age=age;
		Energy = 0; Price = 0; MealQuantity = 0;
	}
	public Animal(string name,string gender, int age ,int energy,int price , int mealQuantity)
		: this(name,gender,age)
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

		if(Energy <= 0) { Sleep(); }
	}

}



/*
 
Animal --

Cat, Dog, Bird, Fish
Properties: Nickname, Age, Gender, Energy, Price, MealQuantity
Methods: Eat(), Sleep(), Play()

PetShop --

Cats[], Dogs[], Birds[], Fishes[]
Methods: RemoveByNickName(), and etc.

Heyvanlar üçün idarə etmək sistem yazmaq lazimdır.
Hansı ki pişiklərin enerjiləri var, oynadıqca enerji itirirlər,
Yatdıqda və ya yemək yedikdə enerjiləri artır, amma
pişikler elədiki enerjiləri 0 olan kimi yatmağa getməlidirlər.
Pişiklər yemək yedikcə hər dəfə bir az boyüyürlər və
dəyərlənirlər.(Price)
Sistemdə ümumi nə qədər yemək yedizdirildiklərini və
ümumi pişiklərin qiymətini hesablayın.

QEYD: Özünüzdən əlavələr edin.
QEYD: Yuxarıda qeyd edilənlər bütün heyvanlara da aiddir.
QEYD: Tom pişik oynundaki kimi. 

 */