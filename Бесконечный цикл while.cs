// Повторяются вычисления и вывод площади круга по вводимому радиусу r до тех пор, пока не введена буква z или Z .
// Беспконечный чикл while!

double square = 0, num = 0, pi = 3.14;  string radCircle = "";

while (true) {
    Console.Write("Введите радиус круга: ");
    radCircle = Console.ReadLine();
    if (radCircle == "Stop" || radCircle == "s") break;
    if (double.TryParse(radCircle, out num)) {
        square = pi*num*num;
        Console.WriteLine("Площадь равна = " + string.Format("{0:0.000}", square)); // ограничение вывода количства символов после запятой
    }
}
