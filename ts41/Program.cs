// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Input(string msg)
{
    Console.WriteLine(msg);
 int res = Convert.ToInt32(Console.ReadLine());
 return res;
}

int[] InpArray(int size)
{
    int[] array = new int[size];
    for (int i=0 ;i<array.Length;++i )
    {
        array [i] = Input($"Enter {1+i} array's element");
    }
    return array;
}

// void PrintArray(int[] array)
// {
//     for (int i=0 ;i<array.Length;++i)
//     {
//         Console.WriteLine(array[i]);
//     }
// }

int PositiveNumbrs(int[] array)
{
    int count=0;
    for(int i=0 ;i<array.Length;++i)
    {
        if(array[i]>0) count++;
        
    }
    return count;
}   

int size = Input("Enter the array's size");
int[] array = InpArray(size);
// PrintArray(array);
Console.WriteLine($"positive numbers amount is {PositiveNumbrs(array)}");