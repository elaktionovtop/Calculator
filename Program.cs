// ВывестиЗаголовок
// запросить число
// считать текст
// преобразовать текст в число
// сделать то же самое со вторым числом
// сложить два числа
// вывести результат
// Выйти

WriteTitle("Калькулятор");

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


