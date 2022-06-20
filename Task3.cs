Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] Cube(int N) {
    double[] arr = new double[N];
    int i= 0;
    int j = 1;

    while (j<=N){
        arr[i] = Math.Pow(j, 3);
        i+=1;
        j+=1;
    }

    return arr;
}

double[] arr = Cube(N);

Console.WriteLine(string.Join(" ",arr));
