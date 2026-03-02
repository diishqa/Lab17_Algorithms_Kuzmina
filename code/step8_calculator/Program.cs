double Sum(double a, double b)
{
    return a + b;
}
double Sub(double a, double b)
{
    return a - b;
}
double Umn(double a, double b)
{
    return a * b;
}
double Del(double a, double b)
{
    return a / b;
}
Console.Write("Введите первое число: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Выберите операцию:");
Console.WriteLine("+");
Console.WriteLine("-");
Console.WriteLine("*");
Console.WriteLine("/");
string op = Console.ReadLine();
double result = 0;

if (op == "+")
{
    result = Sum(n1, n2);
}
else if (op == "-")
{
    result = Sub(n1, n2);
}
else if (op == "*")
{
    result = Umn(n1, n2);
}
else if (op == "/")
{
    result = Del(n1, n2);
}
Console.WriteLine("Результат: " + result);