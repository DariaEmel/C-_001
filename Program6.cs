Console.WriteLine("Введите число: N ");
int N = Convert.ToInt32(Console.ReadLine());
int num;
List<int> nums = new List<int>();
int foo = 10;
while (true) {
    if (N < 1){
        break;
    }
    num = N % foo;
    N = N / foo;
    nums.Add(num);
}
int[] reverse = Enumerable.Reverse(nums).ToArray();
try {
    int third = reverse[2];
    Console.WriteLine("{0}", third);
}
catch {
    Console.WriteLine("третьего значения нет");
}
