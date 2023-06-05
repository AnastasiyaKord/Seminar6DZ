// Задача 41: Пользователь вводит 
// с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int TextToUser(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ReadArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = TextToUser($"Введите {i}-ый элемент массива");
    }

    return array;
}

int CountPositiveElements(int[] array)
{
    int count = 0; 

    for(int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}

int n = TextToUser("Введите колличество элементов: "); 
int[] myArray = ReadArray(n); 
int sum = CountPositiveElements(myArray); 
Console.WriteLine($"Было введено {sum} положительных элемента(-ов)");