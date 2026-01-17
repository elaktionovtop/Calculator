// ВывестиЗаголовок
// запросить число
// считать текст
// преобразовать текст в число
// + запросить знак операции  (+ - * /)
// ввести второе число
// - сложить два числа
// + выполнить операцию в зависимости от знака
// вывести результат
// Выйти

WriteTitle("Калькулятор");

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.Write("Введите знак операции (+ - * /): ");          
string operation = Console.ReadLine();

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

int result = 0;

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

Console.WriteLine($"Результат: {result}");

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


