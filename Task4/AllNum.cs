Console.Clear(); // Очистили консоль перед выводом ответа
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
int reverse = - number;
while (reverse <= number)
{
    Console.Write(reverse);
    Console.Write(" ");
    reverse++;
}