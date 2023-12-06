// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

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


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());



int [] array = CreateArray(max, min, size);

ShowArray(array);



int [] ReverseArray(int [] array) {
    
    int count = array.Length / 2;
    int temp;

    for (int i = 0; i < count; i++) {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

void ShowArrayReverse (int [] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


//ReverseArray(array);

int [] arrayReverse = ReverseArray(array);

ShowArrayReverse(arrayReverse);