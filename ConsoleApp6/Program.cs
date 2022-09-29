//Миронова Анастасия 22-ИСП-1/2 
//задание 2.1 высокий уровень, вариант 4
try
{
    Console.WriteLine("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y:");
    double y = double.Parse(Console.ReadLine());
    if (x >= 0 && x <= 1 && y >= -1 && y <= 1) Console.WriteLine("Принадлежит");
    else Console.WriteLine("Не принадлежит");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}