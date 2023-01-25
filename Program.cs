//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.
void Append (ref string []array, string text)//процедура увеличивает массив на 1 элемент и записывает в него входящую строку
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = text;
}
Console.Clear();
Console.Write("строки через пробел: ");
string? [] input = Console.ReadLine().Split();//разбиение введенной строки по пробелам и запись в массив
string? [] result = new string [0];//создание пустого массива строк под результат
foreach (string element in input)
{
    if(element.Length <= 3) //каждый элемень исходного массива короче 4 символов
        Append(ref result, element);//будет добавлен в результирующий массив
}
Console.WriteLine($"{string.Join(", ", result)}");//вывод результата через запятую