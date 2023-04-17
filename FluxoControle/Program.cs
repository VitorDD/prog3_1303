
string password = "samurai";
string retorno = string.Empty;

if( password.Length < 10 )
{
    retorno = @"Sua senha é muita curta.
                Use ao menos 10 caracteres";
}

else if(password.Length >=15)
{
    retorno = @"sua senha é mto grande.
            use entre 10 e 15 caracteres";
}

else
{
    retorno = @"sua senha esta de acordo";
}

Console.WriteLine(retorno);

// checagem de valor e tipo

/*
em java script podemos fazer assim
var a = "1";
let b = 1;
(a == b) retornara true
(a === b) retornara false
*/

object o = "3";
int j = 4;
if( o is int i )
{
    Console.WriteLine( $"{i} x {j} = {i * j}" );
}
else
{
Console.WriteLine(@"o não é um inteiro,
        portanto não é possivel multiplicar");
}

// comando switch
int number = Random.Shared.Next(1,7);
Console.WriteLine($"meu numero aleatorio é {number}");
switch(number)
{
    case 1:
    Console.WriteLine("um");
    break;
    case 2:
    Console.WriteLine("dois");
    break;
    case 3:
    case 4:
    Console.WriteLine("tres ou quatro");
    goto case 1;

    case 5:
    goto A_label;
    default:
     Console.WriteLine("Default");
     break;
}

Console.WriteLine("depois do fim do swith");

A_label:
Console.WriteLine("depois de A_label");