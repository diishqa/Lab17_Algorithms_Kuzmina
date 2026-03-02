// Console.WriteLine("Выбор одежды по погоде");
// Console.Write("Введите текущую температуру (C): ");
// int temperature = Convert.ToInt32(Console.ReadLine());
// if (temperature >=20)
// {
//     Console.WriteLine("Наденьте легкую одежду");
// }
// else
// {
//     Console.WriteLine("Наденьте теплую одежду");
// }
// Console.WriteLine("Хорошего дня!");

Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущую погоду (жара/холод): ");
string pogoda = Console.ReadLine();
if (pogoda == "жара")
{
    Console.WriteLine("Наденьте футболку");
}
else
{
    Console.WriteLine("Наденьте куртку");
}
Console.WriteLine("Хорошего дня!");

