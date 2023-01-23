int P3 = 0;
int P4 = 0;
int P5 = 0;
Random Rand = new Random();

//Угадайка с пользовательским диапозоном.

while (true)
{
    Console.WriteLine("Добро пожаловать в Угадайку. В этой версии число будет сгенерировано в диапозоне от 0 до числа, которое зададите вы.");
    Console.WriteLine("Для старта введите 0. Для выхода введите -1.");
    P3 = int.Parse(Console.ReadLine());
    if (P3 == -1) break;
    else
    {

        Console.WriteLine("Введите число для генерации загадки.");
        P3 = int.Parse(Console.ReadLine());
        P4 = Rand.Next(0, P3);
        Console.WriteLine("Число сгенерировано. Если вы устанете, введите -1.");
        while (true)
        {
            Console.WriteLine("Введите число.");
            P5 = int.Parse(Console.ReadLine());
            if (P5 == -1) { Console.WriteLine("Вы устали? Ничего страшного. В следующий раз повезёт. Число было " + P4); break; }
            if (P5 < P4) Console.WriteLine("Число меньше загаданного.");
            else if (P5 > P4) Console.WriteLine("Число больше загадонного.");
            else { Console.WriteLine("Поздравляем, Вы угадали!"); break; }
        }
    }
    Console.ReadLine();
}
Console.WriteLine("Приложение остановлено.");
Console.ReadLine();