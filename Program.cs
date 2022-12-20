//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];

ArrayWithRandomNumbers(arr);
System.Console.WriteLine();

int count = 0;
Random rnd = new Random();
for (int d = 0; d < arr.Length; d++)
{
    arr[d] = rnd.Next(100, 1000);

    if (arr[d] % 2 == 0)
    {
        count += 1;
    }
}

void ArrayWithRandomNumbers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
        Console.Write(arr[i] + " ");
    }
}

Console.WriteLine($" всего {arr.Length} чисел, {count} из них чётные");














//System.Console.WriteLine("Введите размер массива");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//int[] arr = int getmassive(8);
//int count = 0;
/*Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);

    if (arr[i] % 2 == 0)
    {
        count += 1;
    }

}*/
//System.Console.WriteLine("Наш массив: [" + string.Join(", ", arr) + "]");
//System.Console.WriteLine($"Количество четных чисел {count}");

