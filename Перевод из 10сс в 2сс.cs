//Преобразование десятичного числа в двоичное

Console.Clear();
Console.Write("Введите число, которое хотите преобразовать: ");
int findNum = int.Parse(Console.ReadLine());

string doubleNum = ""; //заполнение строки 1 и 0
while(findNum > 0) {
    doubleNum += findNum%2;
    findNum /= 2;
}

void ReverseString (string inputStr) {    // функция переворота строки
   int sizeStr = inputStr.Length;
   string reverseStr = "";
   for (int i = sizeStr - 1; i >= 0; i--) {
    reverseStr += inputStr[i];
   }
   System.Console.WriteLine(reverseStr);
}

ReverseString(doubleNum);     // вывод ответа с помощью функции reverse
