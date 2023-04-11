// See https://aka.ms/new-console-template for more information
Console.WriteLine("task36");

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int[] arrayGenerate(int size){
    int[] result = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++){
        result[i] = random.Next(0, 100);
    }
    return result;
}

int summOdd(int[] array){
    int result = 0;
    for (int i=1; i<array.Length; i+=2){
        result+=array[i];
    }
    return result;
}

void test(){
    int[] myArray = arrayGenerate(4);
    int result = summOdd(myArray);
    Console.WriteLine($"[{string.Join(", ", myArray)}] -> {result}");
}

test();