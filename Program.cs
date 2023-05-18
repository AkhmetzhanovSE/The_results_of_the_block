/* Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.WriteLine("Приветствую, сейчас будет выполнено решение с массивом уже заданным в алгоритм.");
string[] array = { "Hello", "2", "world", ":-)", "222" };
Console.Write("[ ");

void Print(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}
Print(array);
Console.Write("]");
Console.WriteLine();
Console.WriteLine("Далее массив будет отфильтрован согласно заданию: длина строк меньше, либо равна 3 символам.");
filteredArray(array);
void filteredArray(string[] array)
{
    Console.Write("[ ");
    string[] newarray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[i] = array[i];
            Console.Write(newarray[i] + " ");
        }
    }
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine("Готово! Если необходимо отфильтровать другой массив, то внесите пожалуйста его вместо заданного в алгоритме массива.");
