Console.WriteLine("Введите число: ");
string N = Console.ReadLine();

int i;
int j = 4;

bool is_palindrom = true;

for (i=0; i<5; i++) {
    if (N[i] != N[j]) {
        is_palindrom = false;
        break;
    }
    j-=1;
} 

if (is_palindrom){
    Console.WriteLine("Число палиндром");
}
else {
    Console.WriteLine("Число не палиндром");
}
