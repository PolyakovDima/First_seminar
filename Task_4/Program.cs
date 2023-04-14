//  Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
//  План действий:
//  1. Запросить у пользователя число
//  2. Проверить его на TryParse
//  3. Повторить те же действия на ещё два числа.
//  4. Запомнив эти числа, дав им имя переменной, сравнить их посредством числа max = 0
//  5. Вывести максимальное число

int max = 0;

Console.Write("Введите число a: ");
string s = Console.ReadLine();

if (int.TryParse(s, out int i))
{
    Console.Write("Введите число b: ");
    string c = Console.ReadLine();

    if (int.TryParse(c, out int j))

    {
        Console.Write("Введите число с: ");
        string o = Console.ReadLine();
        
        if (int.TryParse(o, out int y))

        {
            if (max <= i)
            {
                max = i;
            }

            if (max <= j)
            {
                max = j;
            }

            if (max <= y)
            {
                max = y;
            }
            
            Console.WriteLine("Максимальное число: " + max);
        }

        else
        {
            Console.WriteLine("Ошибка при вводе числа");
        }


    }

    else
    {
        Console.WriteLine("Ошибка при вводе числа");
    }

}
else
{
    Console.WriteLine("Ошибка при вводе числа");
}
