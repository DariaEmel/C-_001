Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] Point(double k1, double k2, double b1, double b2){
    double[] point = new double[2];
    point[0] = (b2-b1)/(k1-k2);
    point[1] = ((b2-b1)/(k1-k2))*k1 + b1;
    return point;
}

string FindPoint(double k1, double k2, double b1, double b2){
    string result;

    if (k1 == k2 && b1 == b2) {
        result = "Прямые совпадают";
    }
    else if (k1 == k2 && b1 != b2) {
        result = "Прямые параллельны";
    }
    else {
        double[] point = Point(k1, k2, b1, b2);
        result = string.Format("Прямые пересекаются в точке ({0:f2};{0:f2})", point[0], point[1]);
    }

    return result;
}

Console.WriteLine("{0}", FindPoint(k1, k2, b1, b2));