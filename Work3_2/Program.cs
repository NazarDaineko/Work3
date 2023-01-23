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