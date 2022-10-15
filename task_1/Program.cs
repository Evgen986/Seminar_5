/* Задача № 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
                Найдите сумму отрицательных и положительных эллементов массива
                Например в массиве [3,9,-8,1,0-7,2-1,8-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
Console.Clear();

int[] array = GetArray(12, -9, 9);
int positivSum = 0;
int negativSum = 0;
PrintArray(array);

foreach(int el in array){
    if (el > 0){
        positivSum += el;
    }else {
        negativSum += el;
    }
}
Console.WriteLine($"Сумма положительных чисел в массиве = {positivSum}");
Console.WriteLine($"Сумма положительных чисел в массиве = {negativSum}");

// Console.WriteLine($"Сумма положительных чисел в массиве = {SumPositiveNumbers(array)}");
// Console.WriteLine($"Сумма отрицательных чисел в массиве = {SumNegativNumbers(array)}");

int [] GetArray (int sizeArray, int minValue, int maxValue){
    int [] arr = new int [sizeArray];
    for (int i = 0; i<sizeArray; i++){
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
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

int SumNegativNumbers (int [] arr)
{
    int result = 0;
    for (int i = 0; i<arr.Length; i++){
        if (arr[i]<0){
            result += arr[i];
        }
    }
    return result;
}

int SumPositiveNumbers (int [] arr)
{
    int result = 0;
    for (int i = 0; i<arr.Length; i++){
        if (arr[i]>0){
            result += arr[i];
        }
    }
    return result;
}