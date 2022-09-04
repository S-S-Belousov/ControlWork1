/// <summary>
/// Функция получения элементов строкового массива меньше четырех символов
/// </summary>
/// <param name="array">Передаваемый строковый массив</param>
/// <returns>Строковый массив с элементами меньше 4 сиволов</returns>/// 
string[] getLessThan4CharactersArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length < 4) size++;
    String[] tempArray = new String[size];
    size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            tempArray[size] = array[i];
            size++;
        }

    }
    return tempArray;
}

Console.WriteLine("Введите количество элементов строкового массива:");
int arraySize;
while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize<1)
{
    Console.WriteLine("Ошибка ввода. Введите целое число, больше 0");
}
String[] array = new string[arraySize];
for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"Введите {i} элемент строкового массива:");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Элементы массива у которых 3 символа или меньше:");
Console.WriteLine($"{string.Join("; ", getLessThan4CharactersArray(array))}");