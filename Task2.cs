Console.Write("Введите координату X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distance(int x1, int x2, int y1, int y2, int z1, int z2){
    return Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)), 2 );
}

Console.WriteLine("Длина отрезка {0}", Distance(x1,x2,y1,y2,z1,z2));

