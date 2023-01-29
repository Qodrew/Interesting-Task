int AckermannFun (int input1Num, int input2Num)
{
    if (input1Num == 0) return input2Num + 1;
    if (input1Num != 0 && input2Num == 0) return AckermannFun(input1Num - 1, 1);
    if (input1Num > 0 && input2Num > 0) return AckermannFun(input1Num - 1, AckermannFun(input1Num, input2Num - 1));
    return AckermannFun(input1Num, input2Num);
}

Console.WriteLine($"A({n68},{m68}) = {AckermannFun(n68, m68)}");
