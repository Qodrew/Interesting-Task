// Простой калькулятор в 4 действия

Console.Clear();
Console.Write("Input num 1: ");
double variableA = double.Parse(Console.ReadLine());
Console.Write("Input num 2: ");
double variableB = double.Parse(Console.ReadLine());
Console.Write("Input arithmetic sign (+-*/): ");
string arSign = Console.ReadLine();
bool statusOper = true;
double logAnsver = 0;
switch (arSign) {
    case "+" : logAnsver = variableA + variableB; break;
    case "-" : logAnsver = variableA - variableB; break;
    case "*" : logAnsver = variableA * variableB; break;
    case "/" : logAnsver = variableA / variableB; break;
    default : statusOper = false; break;
}

if (statusOper == true) {
    Console.WriteLine($"{variableA} {arSign} {variableB} = {logAnsver}");

}
else {
    Console.WriteLine("Unacceptable operation");
}
Console.ReadKey();
