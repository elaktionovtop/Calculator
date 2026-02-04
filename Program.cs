// ВывестиЗаголовок
// цикл
//  считать первое число
//  если отказ 
//      выйти
//  получить знак операции  (+ - * /)
//  если отказ 
//      выйти
//  считать второе число
//  если отказ 
//      выйти
//  выполнить операцию в зависимости от знака
//  вывести результат
// Выйти

WriteTitle("Калькулятор");
while(true)
{
    if(!TryReadDouble("Введите первое число: ", out double number1)) break;
    string operation = GetOperationSign();
    if (string.IsNullOrEmpty(operation)) break;
    if(!TryReadDouble("Введите второе число: ", out double number2)) break;

    Console.WriteLine($"{number1} {operation} {number2} = {Calculate(number1, number2, operation):F2}");
    Console.WriteLine();
}
ExitApp();

// ======================== Методы ========================

void WriteTitle(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
    Console.WriteLine();
}

bool  TryReadDouble(string prompt, out double number)
{
    Console.Write(prompt);
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        number = 0;
        return false;
    }
    bool success = double.TryParse(input, out number);
    while (!success)
    {
        Console.Write("Ошибка! Введите корректное число: ");
        input = Console.ReadLine();
        success = double.TryParse(input, out number);
    }
    return success;
}

string  GetOperationSign()
{ 
    Console.Write("Введите знак операции (+ - * /): ");          
    string operation = Console.ReadLine();
    while (operation != "+" && operation != "-" && operation != "*" && operation != "/"
        && operation != "")
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


