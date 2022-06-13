Console.WriteLine("Введите цифру, обозначающую день недели: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] arr = {
"нет",
"нет",
"нет",
"нет",
"нет",
"да",
"да",
};

Console.WriteLine("{0}", arr[N-1]);