// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int [] CreateArray (int max, int min, int size) {
    int [] array = new int [size];
    for (int i = 0; i < size; i++) {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray (int [] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


void CountEvenNumbers(int [] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count++;
        } 
    }
    Console.WriteLine($"Количество четных чисел в массие равно: {count}");
}


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter array min");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter array max");
//int max = Convert.ToInt32(Console.ReadLine());

int min = 100;
int max = 999;


int [] array = CreateArray(max, min, size);

ShowArray(array);

CountEvenNumbers(array);

