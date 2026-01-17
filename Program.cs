// ВывестиЗаголовок
// запросить число
// считать текст
// преобразовать текст в число
// сделать то же самое со вторым числом
// сложить два числа
// вывести результат
// Выйти

WriteTitle("Калькулятор");

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

int result = number1 + number2;
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


