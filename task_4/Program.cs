/* Задача № 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
                Пример для  массива из 5, а 123 элементов
                [5,18,123,6,2] -> 1
                [1,2,3,6,2] -> 0
                [10,11,12,13,14] -> 5
*/
Console.Clear();

int [] array = GetArray(123, 0, 1000);
int [] array2 = {100, 9, 99, 10,15,35,87,96};
PrintArray(array);
Console.WriteLine($"Колличество элементов массива в соотоветсвующем диапозоне = {FindNumsRange(array, 10, 99)}");


int [] GetArray (int sizeArray, int minValue, int maxValue){
    int [] arr = new int [sizeArray];
    for (int i = 0; i<sizeArray; i++){
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int FindNumsRange (int [] arr, int minValue, int maxValue){
    int count = 0;
    for (int i = 0; i<arr.Length; i++){
        if (arr[i]>=minValue & arr[i]<=maxValue){
            Console.WriteLine(arr[i]);
            count++;
        }
    }
    return count;
}

void PrintArray (int [] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++){
        if (i < arr.Length-1){
            Console.Write(arr[i] + ", ");
        }else{
            Console.Write(arr[i] + "]");
        }        
}
    Console.WriteLine();
}