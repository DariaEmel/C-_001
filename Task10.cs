Console.Write("Введите числа: ");
string[] numbers = Console.ReadLine().Split(',');

int PositiveNumbersCount(string[] numbers){
    int count = 0;

    for (int i = 0; i < numbers.Length; i++){
        int num = Convert.ToInt32(numbers[i]);
        if (num > 0){
            count += 1;
        }
    }
    return count;
}

Console.WriteLine("Положительных чисел {0}", PositiveNumbersCount(numbers));