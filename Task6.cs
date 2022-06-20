Console.Write("Введите числа: ");
string N = Console.ReadLine();

string[] Arr(string N) {
    string[] arr = new string[8];
    string[] words = N.Split(',');

    for (int i = 0; i < words.Length; i++){
        string word = words[i].Replace(" ", string.Empty);
        arr[i] = word;
    }
    for (int i = words.Length; i < 8; i++){
        arr[i] = ".";
    }

    return arr;
}

void PrintArr(string[] arr){
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++){
        string a = arr[i];
        if (a == ".") {
            break;
        }
        Console.Write(arr[i]);
        if (i<7 && arr[i+1]!= "."){
            Console.Write(",");
        }
    }
    Console.Write(']');
}

PrintArr(Arr(N));