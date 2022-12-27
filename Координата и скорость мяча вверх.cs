// В интервале [0, 2 c] с шагом 0.1с вычисляются координаты y = V0 t – g t2/ 2
// и скорости V = V0 – g t мячика, брошеного вертикально вверх с начальной скоростью V0 (V0 вводится с клавиатуры, цикл for).

Console.Write("Введите начальную скорость: ");
double v0 = double.Parse(Console.ReadLine());
double ansver = 0, y = 0, v1 = 0, g = 9.81;

for (double t = 0; t <= 2; t += 0.1) {
    y += v0 * t - (g * t * t) / 2;
    v1 = v0 - g * t;
    Console.WriteLine("Координата мяча = " + Math.Round(y, 2) + " Скорость мяча = " + Math.Round(v1, 2));
}
Console.ReadKey();
