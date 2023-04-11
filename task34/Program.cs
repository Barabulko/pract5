// See https://aka.ms/new-console-template for more information
Console.WriteLine("task34");

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] arrayGenerate(int size){
    int[] result = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++){
        result[i] = random.Next(100, 1000);
    }
    return result;
}

int countEven(int[] array){
    int count = 0;
    for (int i=0; i<array.Length; i++){
        if (array[i]%2==0) count++;
    }
    return count;
}

void test(){
    int[] myArray = arrayGenerate(4);
    int result = countEven(myArray);
    Console.WriteLine($"[{string.Join(", ", myArray)}] -> {result}");
}

test();