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
        b = false;
        h = P - 1;
        while (h > 1)
        {
            if (P % h == 0)
            {
                b = true;
                break;
            }
            h = h - 1;
        }
        if (b == false) Console.WriteLine("Число является простым.");
        else Console.WriteLine("Число не является простым.");


    }

}
Console.WriteLine("Приложение остановлено.");
Console.ReadLine();