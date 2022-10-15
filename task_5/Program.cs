/* Задача № 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
                второй и предпослений и т.д. Результат запишите в новом массиве.
                [1,2,3,4,5] -> [5,8,3]
                [6,7,3,6] -> [36,21]
*/
Console.Clear();
int [] array = GetArray(3, 0, 5);
PrintArray(array);
int [] array2 = ProductPairsNum(array);
PrintArray(array2);

int [] ProductPairsNum (int [] arr){
    int length = 0;
    if (arr.Length%2 == 0){
        length = arr.Length/2;    
    }else{
        length = arr.Length/2+1;
    }
    int [] array = new int[length];
    if(arr.Length%2 == 0){
        for (int i = 0; i<arr.Length/2; i++){
            array[i] = arr[i]*arr[arr.Length-1-i];
        }
    }else{
        for (int i = 0; i<=arr.Length/2; i++){
            if (i == arr.Length/2){
                array[i] = arr[arr.Length/2];
            }else{
                array[i] = arr[i]*arr[arr.Length-1-i];
        }
        }
    }
    return array;
}

int [] GetArray (int sizeArray, int minValue, int maxValue)
{
    int [] arr = new int [sizeArray];
    for (int i =0; i<sizeArray; i++){
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