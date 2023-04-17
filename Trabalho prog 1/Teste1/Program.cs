using System;

public class Program
{
    static string[] unidades = {"", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove"};
    static string[] dezenas = {"", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa"};
    static string[] centenas = {"", "cem", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos"};

    static string NumeroPorExtenso(double numero)
    {
        int inteiro = (int)numero;
        int decimalParte = (int)Math.Round((numero - inteiro) * 100);
        string extenso = "";

        if (inteiro == 0)
        {
            extenso = "zero";
        }
        else if (inteiro < 0)
        {
            extenso = "menos " + NumeroPorExtenso(Math.Abs(numero));
        }
        else
        {
            if (inteiro / 1000000 > 0)
            {
                extenso += NumeroPorExtenso(inteiro / 1000000) + " milhões ";
                inteiro %= 1000000;
            }

            if (inteiro / 1000 > 0)
            {
                extenso += NumeroPorExtenso(inteiro / 1000) + " mil ";
                inteiro %= 1000;
            }

            if (inteiro / 100 > 0)
            {
                extenso += centenas[inteiro / 100] + " ";
                inteiro %= 100;
            }

            if (inteiro > 0)
            {
                if (inteiro < 10)
                {
                    extenso += unidades[inteiro] + " ";
                }
                else if (inteiro < 20)
                {
                    extenso += dezenas[inteiro - 10] + " ";
                }
                else
                {
                    extenso += dezenas[inteiro / 10] + " ";
                    inteiro %= 10;
                    if (inteiro > 0)
                    {
                        extenso += unidades[inteiro] + " ";
                    }
                }
            }

            extenso = extenso.Trim();

            if (decimalParte > 0)
            {
                extenso += " virgula " + NumeroPorExtenso(decimalParte);
            }
        }

        return extenso;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        double numero = Convert.ToDouble(Console.ReadLine());
        string extenso = NumeroPorExtenso(numero);
        Console.WriteLine(extenso);
    }
}
