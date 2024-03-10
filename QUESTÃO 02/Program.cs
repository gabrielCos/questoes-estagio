int num = Int32.Parse(Console.ReadLine());

bool encotrado = false;

int pri = 0, sec = 1;

for(int i = 1; i < num; i++) {
    int prox = pri + sec;
    pri = sec;
    sec = prox;

    if (pri == num) {
        Console.WriteLine($"O numero {num} está na sequência de Fibonacci");
        encotrado = true;
        break;
    }
}

if (!encotrado) {
    Console.WriteLine($"O número {num} não se encontra na sequência de Fibonacci");
}

