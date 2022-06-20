Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int i = 0;
int result = 1;

while (i < b) {
    result *= a;
    i+=1;
}

Console.WriteLine("{0}", result);