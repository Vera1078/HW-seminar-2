System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

while (number < 100 || number > 999)
{
Console.Write("Число неверное. Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());
}

int num = (number / 10) % 10;
System.Console.WriteLine ($"Вторая цифра числа = {num}");
