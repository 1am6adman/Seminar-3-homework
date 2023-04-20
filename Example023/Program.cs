// Функция ввода
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int number = ReadInt("Введите число");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i} ");
}