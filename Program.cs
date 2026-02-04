// ВывестиЗаголовок
// запросить число
// считать текст
// преобразовать текст в число
// получить знак операции  (+ - * /)
// ввести второе число
// выполнить операцию в зависимости от знака
// вывести результат
// Выйти

WriteTitle("Калькулятор");

Console.Write("Введите первое число: ");
string input = Console.ReadLine();
double number1 = double.Parse(input);

string operation = GetOperationSign();

Console.Write("Введите второе число: ");
input = Console.ReadLine();
double number2 = double.Parse(input);

double result = Calculate(number1, number2, operation);
Console.WriteLine($"{number1} {operation} {number2} = {result:F2}");

ExitApp();

// ======================== Методы ========================

void WriteTitle(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
    Console.WriteLine();
}

string  GetOperationSign()
{ 
    Console.Write("Введите знак операции (+ - * /): ");          
    string operation = Console.ReadLine();
    while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
    {
        Console.Write("Ошибка! Введите корректный знак операции (+ - * /): ");
        operation = Console.ReadLine();
    }
    return operation;
}

double Calculate(double num1, double num2, string op)
{
    double res = 0;
    switch (op)
    {
        case "+":
            res = num1 + num2;
            break;
        case "-":
            res = num1 - num2;
            break;
        case "*":
            res = num1 * num2;
            break;
        case "/":
            res = num1 / num2;
            break;
        default:
            Console.WriteLine("Ошибка! Некорректный знак операции.");
            break;
    }
    return res;
}

void ExitApp()
{
    Console.WriteLine();
    Console.Write("Для выхода нажми Enter");
    Console.ReadLine();
}


