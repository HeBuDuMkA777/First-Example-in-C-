Console.Clear(); // Очистили консоль перед выводом ответа
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()); 
Console.Write("Введите число Б: ");
int numberB = int.Parse(Console.ReadLine()); 

if (numberA > numberB)
{
    int max = numberA;
    Console.Write("max = ");
    Console.WriteLine(max);
}
else
{
    int max = numberB;
    Console.Write("max = ");
    Console.WriteLine(max);
}