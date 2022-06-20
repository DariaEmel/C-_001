Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum(int N) {
    int result = 0;
    int b = Convert.ToString(N).Length;
    int a=0;
    for (int i = 0; i <= b; i++){
        a = N % 10;
        result += a;
        N = (N - a) / 10;
    }

    return result;
}

Console.WriteLine("{0}", Sum(N));