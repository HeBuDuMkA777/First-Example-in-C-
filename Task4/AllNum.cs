Console.Clear(); // Очистили консоль перед выводом ответа
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
int first = 2;
while (first <= number)
{
    Console.Write(first);
    Console.Write(" ");
    first = first + 2;
}