// ВывестиЗаголовок
// запросить число
// считать текст
// преобразовать текст в число
// запросить знак операции  (+ - * /)
// ввести второе число
// выполнить операцию в зависимости от знака
// вывести результат
// Выйти

WriteTitle("Калькулятор");

Console.Write("Введите первое число: ");
string input = Console.ReadLine();
double number1 = double.Parse(input);

Console.Write("Введите знак операции (+ - * /): ");          
string operation = Console.ReadLine();

Console.Write("Введите второе число: ");
input = Console.ReadLine();
double number2 = double.Parse(input);

double result = 0;

if (operation == "+")
{
    result = number1 + number2;
}
if (operation == "-")
{
    result = number1 - number2;
}
if (operation == "*")
{
    result = number1 * number2;
}
if (operation == "/")
{
    result = number1 / number2;
}

Console.WriteLine($"{number1} {operation} {number2} = {result:F2}");

ExitApp();

void WriteTitle(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
    Console.WriteLine();
}

void ExitApp()
{
    Console.WriteLine();
    Console.Write("Для выхода нажми Enter");
    Console.ReadLine();
}


