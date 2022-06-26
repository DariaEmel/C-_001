int[] numbers = new int[6];

int OddSum(int[] numbers){
    for (int i = 0; i<numbers.Length; i++ ){
        numbers[i] = new Random().Next(-50, 50);
    }

    int sum = 0;

    for (int i = 0; i<numbers.Length; i++ ){
        int j = i + 1;
        if (j % 2 == 1)
        {
            sum+=numbers[i];
        }
  }
  return sum;
}

int sum = OddSum(numbers);

Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine("Сумма чисел на нечетных позициях {0}", sum);
