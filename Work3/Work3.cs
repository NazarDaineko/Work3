#region Task 1

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

#endregion

#region Task 2

//Игра 21.

int f;
int sum1 = 0;
int v = 0;
string i;

while (true)
{
    sum1 = 0;
    v = 0;

    Console.WriteLine("Добро пожаловать в игру 21. Скажите, сколько карт у вас на руках? (Введите ноль для остановки.)");
    f = int.Parse(Console.ReadLine());
    if (f == 0) break;
    else
    {

        for (int x = 0; x < f; x++)
        {
            v = v + 1;
            Console.WriteLine("Введите номинал " + v + "-й карты карты.");
            i = Console.ReadLine();

            switch (i)
            {
                case "J":
                    sum1 = sum1 + 10; break;

                case "Q":
                    sum1 = sum1 + 10; break;

                case "K":
                    sum1 = sum1 + 10; break;

                case "T":
                    sum1 = sum1 + 10; break;

                case "10":
                    sum1 = sum1 + 10; break;

                case "1":
                    sum1 = sum1 + 1; break;

                case "2":
                    sum1 = sum1 + 2; break;

                case "3":
                    sum1 = sum1 + 3; break;

                case "4":
                    sum1 = sum1 + 4; break;

                case "5":
                    sum1 = sum1 + 5; break;

                case "6":
                    sum1 = sum1 + 6; break;

                case "7":
                    sum1 = sum1 + 7; break;

                case "8":
                    sum1 = sum1 + 8; break;

                case "9":
                    sum1 = sum1 + 9; break;

                default: Console.WriteLine("В стандартной колоде нет таких карт."); return;
            }

        }

        if (sum1 < 21)
        {
            Console.WriteLine("Сумма значений ваших карт - " + sum1 + ". Можно попробовать набрать ещё.");
        }
        else if (sum1 > 21) Console.WriteLine("Сумма значений ваших карт - " + sum1 + ". Увы, вы перебрали.");
        else Console.WriteLine("Сумма значений ваших карт - " + sum1 + ". Это победа.");

        Console.ReadLine();
    }
}
Console.WriteLine("Приложение остановлено.");
Console.ReadLine();
#endregion

#region Task 3

//Определение простоты числа.

int P = 0;
int h = 0;
bool b = false;


Console.WriteLine("Введите число для определения.(Введите 0 для остановки приложения.)");
while (true)
{

    P = int.Parse(Console.ReadLine());
    if (P == 0) break;
    else
    {
        b= false;
        h = P-1;
        while (h > 1)
        {
            if (P % h == 0) 
            { 
                b = true; 
                break; 
            }
            h=h-1;
        }
        if (b == false) Console.WriteLine("Число является простым.");
        else Console.WriteLine("Число не является простым.");

        
    }

}
Console.WriteLine("Приложение остановлено.");
Console.ReadLine();
#endregion

#region Task 4

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
                if (P1 < P2) P2=P1;
            }
        }
        Console.WriteLine("Зафиксирована остановка ввода. Наименьшее число " + P2);
    }
}
Console.WriteLine("Приложение остановлено.");
Console.ReadLine();
#endregion

#region Task 5

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
Console.ReadLine() ;
#endregion