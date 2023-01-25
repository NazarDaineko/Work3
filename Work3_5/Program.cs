using System;

int enter = 0;
int rangeNumber = 0;
int target = 0;
int userTry = 0;
Random Rand = new Random();

//Угадайка с пользовательским диапозоном.

Console.WriteLine("Добро пожаловать в Угадайку. В этой версии число будет сгенерировано в диапозоне от 0 до числа, которое зададите вы.");

while (true)
{
    Console.WriteLine("Для старта введите 0. Для выхода введите -1.");
    enter = int.Parse(Console.ReadLine());
    if (enter == -1) break;
    else if (enter == 0) 
    {

        Console.WriteLine("Введите число для генерации загадки.");
        rangeNumber = int.Parse(Console.ReadLine());
        target = Rand.Next(0, rangeNumber);
        Console.WriteLine("Число сгенерировано. Если вы устанете, оставьте строку пустой.");
        while (true)
        {
            Console.WriteLine("Введите число.");
            var userInput = Console.ReadLine();
            if (userInput == "") { Console.WriteLine("Вы устали? Ничего страшного. В следующий раз повезёт. Число было " + target); break; }
            userTry = int.Parse(userInput);
            if (userTry < target) Console.WriteLine("Число меньше загаданного.");
            else if (userTry > target) Console.WriteLine("Число больше загадонного.");
            else { Console.WriteLine("Поздравляем, Вы угадали!"); Console.ReadLine(); break; }
        }
    }
}
Console.WriteLine("Приложение остановлено.");
Console.ReadLine();