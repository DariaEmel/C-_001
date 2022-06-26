double[] numbers = new double[6];

double MinMaxDifference(double[] numbers){
    for (int i = 0; i<numbers.Length; i++ ){
        numbers[i] = new Random().NextDouble() * 7;
    }

    double min = numbers[0];
    double max = numbers[0];

    for (int i = 0; i<numbers.Length; i++ ){
        if (numbers[i] > max){
            max = numbers[i];
        }
        if (numbers[i] < min){
            min = numbers[i];
        }
  }

  Console.WriteLine("Max {0}", max);
  Console.WriteLine("Min {0}", min);

  return max - min;
}

double diff = MinMaxDifference(numbers);

Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine("Разница {0}", diff);