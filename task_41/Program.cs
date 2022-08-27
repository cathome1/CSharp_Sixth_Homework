// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите колличество вводимых чисел: ");
int counter = Convert.ToInt32(Console.ReadLine());
int[] FillArray(int count)
{
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите {i+1}е число :");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
int CountOfPositive(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
int[] array = FillArray(counter);
System.Console.WriteLine($"Из введенных вами чисел всего {CountOfPositive(array)} чисел больше 0");
