// Задание 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue){
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int NumberEvenNumbers(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] % 2 == 0){
//             count++;
//         }
//     }
//     return count;
// }

// int[] myArray = CreateRandomArray(4, 100, 999);
// PrintArray(myArray);
// Console.WriteLine(NumberEvenNumbers(myArray));

// Задание 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue){
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int SumOddNumbers(int[] array){
//     int summ = 0;
//     for(int i = 1; i < array.Length; i += 2){
//         summ += array[i];
//     }
//     return summ;
// }

// int[] myArray = CreateRandomArray(4, 1, 9);
// PrintArray(myArray);
// Console.WriteLine(SumOddNumbers(myArray));

// Задание 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int size, double minValue, double maxValue){
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void PrintArray(double[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double Min(double[] array){
    double min = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] < array [i + 1]){
            min = array[i];
        } 
    }
    return min;
}

double Max(double[] array){
    double max = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] > array [i + 1]){
            max = array[i];
        } 
    }
    return max;
}

double[] myArray = CreateRandomArray(4, 1, 9);
PrintArray(myArray);
Console.WriteLine(Min(myArray));
Console.WriteLine(Max(myArray));