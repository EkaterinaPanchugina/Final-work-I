/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать 
 на старте выполнения алгориrма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
Пример: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]*/

//Метод поиска элементов, где не более 3 символов
string[] GetArrayLessOrEqualSymbols(string[] array)
{
    string[] newArray = new string[0];
    int indexNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize<string>(ref newArray, newArray.Length + 1);
            newArray[indexNewArray] = array[i];
            indexNewArray++;
        }
    }
    return newArray;
}

// Метод вывода на печать
void PrintArrayToConsole(string[] array)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}

// Создаем изначальный массив размерностью 5 и новый массив, который получим из метода 

string[] array = new string[5] {"hello", "2", "world", ":-)", "123456"};
string[] newArray = GetArrayLessOrEqualSymbols(array);

Console.WriteLine("Your array:");
PrintArrayToConsole(array);

Console.WriteLine("Array with elements <= 3:");
PrintArrayToConsole(newArray);
