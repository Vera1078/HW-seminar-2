// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
// 7 -> да
// 1 -> нет
System.Console.WriteLine("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine ());

 if (number < 1 || number > 7)
 {
    System.Console.WriteLine("Число указано неверно. Введите число от 1 до 7");
 }

 else if (number <= 5)
 {
    System.Console.WriteLine("Рабочий день");
 }

 else if (number == 6 || number == 7)
 {
    System.Console.WriteLine("Выходной день");
 }