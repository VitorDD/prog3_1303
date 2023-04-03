
// operadores unários
int x = 5;
int incrementoPosfixado = x++; //6
incrementoPosfixado++;
x++; x = x + 1;
int incrementoPrefixado = ++x;
Console.WriteLine(
     $"Posfixado: {incrementoPosfixado}" 
);
Console.WriteLine(
    $"prefixado: {incrementoPrefixado}"
);

// como obter o tipo de uma variavel
Type tipoDeInteiro = typeof(int);
Type tipoDeX = x.GetType();
//como obter o nome de uma variavel
string nomeDaVariavel = nameof(x);
int quantosBytes = sizeof(int);

Console.WriteLine( 
    "nome da var: " + nomeDaVariavel 
);

//operadores de atribuição
int p = 6;
p += 3; //equivalente a p = p + 3;
Console.WriteLine($"+={p}");
p -= 3; // equivalente a p = p -3;
Console.WriteLine($"-={p}");
p *= 3; // equivalente a p = p *3;
Console.WriteLine($"*={p}");
p /= 3; // equivalente a p = p /3;
Console.WriteLine($"/={p}");

// operadores logicos

bool a = true; 
bool b = false;
WriteLine($"AND  | a           | b   ");
WriteLine($"a    | {a & a, -5} | {a & b, -5}");
WriteLine($"b    | {b & a, -5} | {b & b, -5}");
WriteLine();
WriteLine($"OR   | a           | b   ");
WriteLine($"a    | {a | a, -5} | {a | b, -5}");
WriteLine($"b    | {b | a, -5} | {b | b, -5}");
WriteLine();
WriteLine($"XOR  | a           | b");
WriteLine($"a    | {a ^ a, -5} | {a ^ b, -5}");
WriteLine($"b    | {b ^ a, -5} | {b ^ b, -5}");
WriteLine();

