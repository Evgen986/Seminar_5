/* Задача № 32: Напишите программу замены элементов массива: положительные элементы замените на ссответсвующие отрицательные и наооборот.
                [-4,-8,8,2] -> [4,8,-8,-2]
*/
Console.Clear();

int [] array = GetArray(6, -8, 8);
PrintArray(array);
ChangeRangeValues(array);
PrintArray(array);

int [] GetArray (int sizeArray, int minValue, int maxValue)
{
    int [] arr = new int [sizeArray];
    for (int i =0; i<sizeArray; i++){
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
return arr;
}

void ChangeRangeValues (int [] arr){
    for(int i=0; i< arr.Length; i++){
        arr[i] *= -1;
    }
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