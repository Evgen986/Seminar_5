/* Задача № 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
                4; массив [6,7,19,345,3] -> нет
                -3; массив [6,7,19,345,3] -> да
*/
Console.Clear();

int [] array = GetArray(6, -5, 5);
PrintArray(array);
Console.WriteLine(FindNumArray(array, 3));

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

bool FindNumArray (int [] arr, int num){
    bool result = false;
    if(num<0){
        num*=-1;
    }
    for(int i = 0; i<arr.Length; i++){
        if (arr[i] < 0){
            arr[i] *= -1;
        }
        if(arr[i] == num){
            result = true;
        }
    }
    return result;
}