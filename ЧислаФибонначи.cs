//Вывод чисел Фибонначи не через рекурсию начиная с 0 и 1

Console.Clear();
int firstNumFib = 0, secondNumFib = 1, accumFibNum = secondNumFib; //accum необходим для шага в числФибоначи
Console.Write("Введите сколько чисел Фиббоначи нужно показать: ");
int countFibNum = int.Parse(Console.ReadLine());

void printFibNum (int inputCountFib) {                  // функция вывода чисел фибоначи по заданному их количеству
    int[] resultFibNum = new int[inputCountFib];
    Console.Write($"{firstNumFib} {secondNumFib} ");
    for (int i = 2; i < inputCountFib; i++) {
        resultFibNum[i] = firstNumFib + secondNumFib;
        accumFibNum += secondNumFib ;
        firstNumFib = secondNumFib;
        secondNumFib = accumFibNum - firstNumFib;
        Console.Write($"{resultFibNum[i]} ");
    }
}
printFibNum(countFibNum);
