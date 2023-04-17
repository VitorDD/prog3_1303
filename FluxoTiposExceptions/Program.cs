
// operadores unários
using FluxoTiposExceptions.Classes;

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


//----------------------------



Animal[] animals = new Animal[]
{
 new Cat{
     Name = "Garfield"
        , Born = new DateTime(year:2022, month:8, day:23)
        , legs = 4 
        , IsDomestic = true 
     },
      null,
     new Cat{
        Name = "Mimi"
        , Born = new DateTime(year:1994, month:6, day:12)
        , legs = 4 
        , IsDomestic = true 
     },
     new Animal{
        Name = "eu mesmo"
        , Born = new(year:1984, month:7, day:5)
        , legs = 2
     },
     new Spider{
        Name = "Peter Parker"
        , Born = DateTime.Today 
        , legs = 8 
        , IsPoisonous = true 
     },
     new Spider{
        Name = "Eddie Brock"
       , Born = DateTime.Today
       , IsPoisonous = true
       , legs = 8
     }


};

/* variaveis de controle para laços de repetição
3 tipos de variaveis para controle de repetição
1: flag -bandeirinha, booleano que indica se para ou continua
2: counter - contador, conta quantas vzs a repetição ocorreu
3: acumulador - permite acumular valores a cada repetição
*/

// laço for

for(int i = 0; i < animals.Length; i++)
{
   string message = string.Empty;
   if(animals[i] != null)
   {
   message = $"Nome: {animals[i].Name} ";
   message += $"Data: {animals[i].Born.ToShortDateString()} ";
   message += $"Patas: {animals[i].legs} ";
   Console.WriteLine(message);
   }
};

// laço de repetição para cada
Console.WriteLine("\n---FOREACH---\n");
foreach(  Animal animal in animals  )
{

string message = string.Empty;
if (animal != null )
{
 message += $"nome: {animal.Name}";

}
Console.WriteLine(message);
}