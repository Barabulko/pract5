// See https://aka.ms/new-console-template for more information
Console.WriteLine("task38");

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] arrayGenerate(int size){
    double[] result = new double[size];
    Random random = new Random();
    for (int i=0; i<size; i++){
        result[i] = random.NextDouble()*100;
    }
    return result;
}

double diffMinMax(double[] array){
    double min = array.Min();
    double max = array.Max();
    return max-min;
}

void test(){
    double[] myArray = arrayGenerate(5);
    double result = diffMinMax(myArray);
    Console.WriteLine($"[{string.Join(", ", myArray)}] -> {result}");
}

test();