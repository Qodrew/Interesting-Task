// Генерируются случайные числа в интервале (– 40, 40) до тех пор,
// пока очередное число не превышает 30. Выводятся только нечетные числа
// и сообщения: отрицательное – положительное

Random rnd = new Random();
int num1 = rnd.Next(-40, 40);
do {
    num1 = rnd.Next(-40, 40);
    if (num1 % 2 != 0) {
        if ( num1 > 0) {
            Console.WriteLine($"{num1} - положительное");
        }
        else {
            Console.WriteLine($"{num1} - отрицательное");
        }
    }
}
while (num1 < 31);
Console.ReadKey();
