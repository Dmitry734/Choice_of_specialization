//Задача

Console.WriteLine("Программа, которая из имеющегося массива строк формрует массив строк длинна которых не превышает 3-х символов.");

Console.WriteLine("");
//Console.WriteLine("Сформируем исходный (заданный) массив");
Console.WriteLine("");
Console.WriteLine("====================== Блок ввода значний ========================");
Console.WriteLine("");

int n = 0;
while (n <= 0)
{
    Console.Write("Введите размер(целое, >0) исходного массива : ");
    int.TryParse(Console.ReadLine()!, out n);
    if (n <= 0)
    { Console.WriteLine("Требуется ввести верные значения"); }
}
Console.WriteLine("=        =       =       =       =  ");
Console.WriteLine("");
string[] arr = CreateArray_by_input(n);

Console.WriteLine("");
Console.WriteLine("============================ Результат ============================");
Console.Write("\n");
string[] new_arr = Array_copy_all_elements_if_lenght_more_then_three(ref arr);
Console.Write("\n");
Console.Write("Исходный массив: \n");
Array_Output(ref arr);
Console.WriteLine("");
Console.WriteLine("");
Console.Write("Преобразованный массив: \n");
Array_Output(ref new_arr);

Console.Write("\n");
Console.Write("=============================\n");
Console.WriteLine("");
Console.Write("НАЖМИТЕ 'ENTER' ДЛЯ ЗАВЕРШЕНИЯ ПРОГРАММЫ");
Console.ReadLine();
Console.WriteLine("");

//==========================================================================================================
//FUNCTIONS
//==========================================================================================================

void Array_Output(ref string[] _array)
{
    Console.Write("[");
    for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"\"{_array[i]}\"");
        if (i != _array.Length - 1)
        {
            Console.Write(",  ");
        }
    }
    Console.Write("]");
}

string[] Array_copy_all_elements_if_lenght_more_then_three(ref string[] _array)
{
    int[] _arr_position = new int[_array.Length];
    int counter = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i].Length <= 3)
        {
            _arr_position[i] = i;
            counter++;
        }
        else _arr_position[i] = -1;
    }

    string[] _new_arr = new string[counter];
    counter = 0;
    for (int i = 0; i < _arr_position.Length; i++)
    {
        if (_arr_position[i] != -1)
        {
            _new_arr[counter] = _array[_arr_position[i]];
            counter++;
        }
    }

    return _new_arr;
}

string[] CreateArray_by_input(int _size)
{
    //string a;
    string[] _array = new string[_size];
    for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1}: ");
        _array[i] = Console.ReadLine()!;
        //_array[i] = a;
    }

    Console.WriteLine();
    return _array;
}
