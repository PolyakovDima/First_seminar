// Напишите программу, которая на вход принимает два числа и выдаёт какое число больше, а какое меньшее.
// План действий:
//  1)Запросить у пользователя число командой Write.
//  2)Поставить цикл и ввести переменную на его число.
//  3)Запомнить это число.
//  4) Дальше поставить цикл на второй запрос числа.
//  5) Запомнить это число.
//  6) Сравнить два эти числа.

Console.Write("Введите число a: ");
string s = Console.ReadLine();

if (int.TryParse(s, out int i))
{
    Console.Write("Введите число b: ");
    string c = Console.ReadLine();

    if (int.TryParse(c, out int j))

    {
        if (i > j){
            Console.WriteLine(s);
        }
        else{
            Console.WriteLine(c);
        }
    }

    else
    {
        Console.WriteLine("Ошибка при введение числа");
    }

}
else
{
    Console.WriteLine("Ошибка при введение числа");
}


//Console.Write("Введите число a: ");
//int i = int.Parse(Console.ReadLine());

//Console.Write("Введите число b: ");
//int j = int.Parse(Console.ReadLine());

//if (i > j){
   // Console.WriteLine(i);
//}
//else{
   // Console.WriteLine(j);
//}
