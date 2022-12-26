double n = 0, sum = 0; string s = "";
while (true) // бесконечный цикл while
{
Console.Write("Введите число: ");
s = Console.ReadLine(); // ввод
if (s == "Q") break; // выход из цикла по условию
if (double.TryParse(s, out n)) // преобразование в double
{ sum += n; // суммирование чисел
Console.WriteLine("сумма = " + sum); }
}
