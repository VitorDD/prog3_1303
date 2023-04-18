Console.WriteLine("Calculo Fatorial Recursivo e tabuada");
Console.WriteLine("--------------------------");
Console.WriteLine();

Console.WriteLine("digite um numero:");
int numero = Convert.ToInt32(Console.ReadLine());


/*
//fatorial e fibonacci
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"fatorial de {numero} é {Factorial(numero)}"); 
Console.WriteLine($"Fibonacci de {numero} é {Fibonacci(numero)}");

static int Factorial(int number)
{
    //caso base 1
    if(number < 0)
    {
        throw new ArgumentException(
            message: $"a função fatorial não suporta numeros negativos. input{number}",
            paramName: nameof(number)
        );
    }
    else if(number == 0) // caso base 2
    {
        return 1;
    }
    else // caso recursivo
    {
        return number * Factorial(number - 1);
    }
}


static long Fibonacci(int n)
{
    if(n <= 2L ) // caso base
        return 1L;

        return Fibonacci(n - 1 ) + Fibonacci (n -2);
}
*/
//--------------------------------------------------------------------------
//tabuada

static void Multiplicationwhile(int n)
{
    int fator = 1;
    while(fator <= 10)
    {
        Console.WriteLine($"{n} x {fator} = {n * fator}");
        fator++;
    } 
}

