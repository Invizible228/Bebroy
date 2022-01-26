// See https://aka.ms/new-console-template for more information
Console.Write("Введите А:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите B:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите значение:\n1 - сложение\n2 - вычитание\n3 - умножение\n4 - деление");
int ans = int.Parse(Console.ReadLine());
switch (ans)
{
    //case 1:
    //    Console.WriteLine($"Ответ:{a + b}");
    //    break;
    case 2:
        Console.WriteLine($"Ответ:{a - b}");
        break;
        //case 3:
        //    Console.WriteLine($"Ответ:{a * b}");
        //    break;
        //case 4:
        //    Console.WriteLine($"Ответ:{a / b}");
        //    break;
}
