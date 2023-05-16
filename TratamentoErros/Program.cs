//menu de inicialização
string entrada = string.Empty;
Console.WriteLine("-----------------------------------");
Console.WriteLine("Tratamento de erros");
Console.WriteLine("-----------------------------------");

do{
    Console.WriteLine("");
    Console.WriteLine("Selecione uma das opções abaixo:");
    Console.WriteLine("1 - Tratamento de erro");
    Console.WriteLine("2 - Try {} catch { }");
    Console.WriteLine("3 - Catch com filtros");
    Console.WriteLine("4 - ");
    Console.WriteLine("5 - ");
    Console.WriteLine("0 - Sair");

    entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1" :
            //int count = int.Parse("abc");
            bool aux = true;
            while(aux)
            {
        

                Console.WriteLine("quantos ovos na cesta?");
                string? input = Console.ReadLine();
                if( int.TryParse( input, out int count ) )
                {
                    Console.WriteLine($"existem {count} ovos no cesto.");
                    aux = false;
                }
                else
                {
                    Console.WriteLine("Numero invalido.");
                    aux = true;
                }
            }
        break;

        case "2" :

            Console.WriteLine("Antes da validação.");
            Console.WriteLine("Informe sua idade:");
            String input2 = Console.ReadLine();
            try
            {
                int age = int.Parse(input2);
                //forçando erro de indice fora dos limites do vetor
                int[] vetInteiros = {10,11,12,13};
                Console.WriteLine( vetInteiros[vetInteiros.Length - 1] );
            }
            catch ( IndexOutOfRangeException ixorgex )
            {
                Console.WriteLine("Erro, posição inexistente no vetor.");
            }
            catch ( FormatException fex )
            {
                Console.WriteLine("Erro de formato invalido de dados.");

            }
            catch( Exception ex )
            {
                Console.WriteLine("Ocorreu um erro. Dados invalidos.");
                Console.WriteLine($"{ex.GetType()} : {ex.Message}");

            }
            Console.WriteLine("depois da validação.");

        break;

        case "3" :

        Console.WriteLine("Informe um valor:");
        string quantia = Console.ReadLine();
        if( string.IsNullOrEmpty(quantia) )
            Console.WriteLine("Quantia invalida");
        else
        {

            try
            {
                decimal amountValue = decimal.Parse(quantia);
                Console.WriteLine($"Valor formatado: {amountValue:C}");
            }
            catch(FormatException) when (quantia.Contains("$"))
            {
            Console.WriteLine("o valor deve ser informado sem $");
            }
            catch(FormatException fex) 
            {
            Console.WriteLine("informe apenas os digitos.");
            }
        }

        break;

        case "4" :
        break;

        case "5" :
        break;

        case "0" :
        break;

        default:
            Console.WriteLine("Opção invalida!");
        break;

    } 

}while( !entrada.Equals("0") && 
        !string.IsNullOrEmpty(entrada) );
