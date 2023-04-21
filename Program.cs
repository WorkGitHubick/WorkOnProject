int result = 0;

Console.WriteLine("1 - Умножение\n2 - Деление\n3 - Сложение\n4 - Вычитание");

Console.Write("Выберите действие: ");
int choise = int.Parse(Console.ReadLine());

switch (choise)
{
    case 1:
        result = Multi();
        break;
    case 2:
        result = Div();
        break;



    case 4:
        result = Sum();
        break;
}

Console.WriteLine($"Ответ: {result}");


int Multi()
{
    int res;
    Console.Write("Введите a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите b: ");
    int b = int.Parse(Console.ReadLine());
    res = a * b;
    return res;
}

int Div()
{
    int res;
    Console.Write("Введите медленее a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите b: ");
    int b = int.Parse(Console.ReadLine());
    res = a / b;
    return res;
}












int Dif()
{
    int res;
    Console.Write("Введите a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите b: ");
    int b = int.Parse(Console.ReadLine());
    res = a + b;
    return res;
}
