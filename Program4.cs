Console.WriteLine("Введите число: N ");
int N = Convert.ToInt32(Console.ReadLine());
List<int> anArray = new List<int>();
for (int i = 1; i <= N; i++)
{
    if ((i % 2) == 0)
    {
        anArray.Add(i);
    }
}        
Console.WriteLine("{0}", string.Join(", ", anArray));
