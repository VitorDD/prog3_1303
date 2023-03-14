static void FormatString(
    string stringToFormat
) {
stringToFormat.Replace("Mundo", "Marte");
}

static string FormatReturningString(string stringToFormat)
    {
        return stringToFormat.Replace("Mundo", "Marte");
    }

    var mensagem = "olá, Mundo!!";
    // invocando o metodo sem retorno
    FormatString(mensagem);
Console.WriteLine(mensagem);

var outramensagem = "bom dia Mundo!";
Console.WriteLine( FormatReturningString(outramensagem) );

