// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


bool IsSumOfDigitEven(int num) {
    int sum = 0;
    while (num != 0) {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum % 2 == 0;
}



while (true) {
    Console.WriteLine("Введите целое число");
    string input = Console.ReadLine();

    if (input.ToLower() == "q") {
        Console.WriteLine("Программа завершена");
        break;
    }

    if(int.TryParse(input, out int number)) {
        if (IsSumOfDigitEven(number)) {
            Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена");
            break;
        }
    } else {
        Console.WriteLine("Не корректный ввод");
    }

}