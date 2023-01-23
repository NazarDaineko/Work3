//Нахождение наименьшего эл-та последовательности.

int P1 = 0;
int P2 = int.MaxValue;


while (true)
{
    Console.WriteLine("Введите последовательность. Введите 1 для начала ввода, введите 0 для остановки приложения.");
    Console.WriteLine("(до начала ввода последовательности).");
    P1 = int.Parse(Console.ReadLine());
    if (P1 == 0) break;
    else
    {
        Console.WriteLine("Начните ввод последовательности (введите 0 для остановки).");
        while (true)
        {
            P1 = int.Parse(Console.ReadLine());
            if (P1 == 0) { Console.WriteLine(); break; }
            else
            {
                if (P1 < P2) P2 = P1;
            }
        }
        Console.WriteLine("Зафиксирована остановка ввода. Наименьшее число " + P2);
    }
}
Console.WriteLine("Приложение остановлено.");
Console.ReadLine();