//Заказано приложение для определения чётности числа.

int N;

while (true)
{
    Console.WriteLine("Введите число для определения.(Введите 0 для остановки приложения.)");
    N = int.Parse (Console.ReadLine());
    if (N == 0)
    {
        Console.WriteLine("Приложение остановлено.");
        break;
    }
    else if (N % 2 == 0) Console.WriteLine("Число является чётным.");
    else Console.WriteLine("Число является нечётным.");
}
Console.ReadLine();