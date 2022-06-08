Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

List<int> anArray = new List<int>();
anArray.Add(num1);
anArray.Add(num2);
anArray.Add(num3);

int m = anArray.Max();
 Console.WriteLine("max = {0}", m );
 
           