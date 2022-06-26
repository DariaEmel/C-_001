int[] numbers = new int[5];

int PositiveNumbersAmount(int[] numbers){
    for (int i = 0; i<numbers.Length; i++ ){
        numbers[i] = new Random().Next(100, 1000);
    }

    int amount = 0;

    for (int i = 0; i<numbers.Length; i++ ){
        if (numbers[i] % 2 == 0)
        {
            amount+=1;
        }
  }
  return amount;
}

int amount = PositiveNumbersAmount(numbers);

Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine("Чётных чисел в массиве {0}", amount);