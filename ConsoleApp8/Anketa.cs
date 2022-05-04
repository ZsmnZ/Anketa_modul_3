using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Введите имя:");
		var name = Console.ReadLine();
		Console.WriteLine("Сколько вам лет:");
		var age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите вашу дату рождения: ");
		var birthdate = Console.ReadLine();
		Console.WriteLine($"Вас зовут {name} \nВаш возраст {age} \nДата рождения{birthdate}");
		Console.ReadKey();
	}
}