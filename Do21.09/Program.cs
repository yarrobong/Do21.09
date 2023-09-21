Console.WriteLine("Введите число для A: ");
string input = (Console.ReadLine());
int a;
if (int.TryParse(input, out a))
{
    double y = (Math.Sin(4) * a) / (1 + (Math.Cos(4) * a)) * ((Math.Cos(2 * a)) / (1 + Math.Cos(2 * a)));
    Console.WriteLine("Результат: " + y);
}
else
{
    Console.WriteLine("Вы ввели некоректное значение");
}

Console.WriteLine("Введите число для A: ");
input = (Console.ReadLine());

if (int.TryParse(input, out a))
{
    double z = Math.Tan(3 / 2 * Math.PI - a);
    Console.WriteLine("Результат: " + z);
}
else
{
    Console.WriteLine("Вы ввели некоректное значение");
}