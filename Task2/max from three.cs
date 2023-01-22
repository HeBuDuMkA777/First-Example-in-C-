Console.Clear(); // Очистили консоль перед выводом ответа
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()); 
Console.Write("Введите третье числ: ");
int numberC = int.Parse(Console.ReadLine()); 

if (numberA > numberB & numberA > numberC)
{
    int max = numberA;
    Console.Write("max = ");
    Console.WriteLine(max);
}
if (numberB > numberA & numberB > numberC)
{
    int max = numberB;
    Console.Write("max = ");
    Console.WriteLine(max);
}
if (numberC > numberA & numberC > numberB)
{
    int max = numberC;
    Console.Write("max = ");
    Console.WriteLine(max);
}