Console.WriteLine("Введите число: N ");
int N = Convert.ToInt32(Console.ReadLine());
int num;
List<int> nums = new List<int>();
int i;
int foo = 10;
for (i=0; i<3; i++){
    num = N % foo;
    nums.Add(num);
    N = N / foo;
}

Console.WriteLine("{0}", nums[1]);