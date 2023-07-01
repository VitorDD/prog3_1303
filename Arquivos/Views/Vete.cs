using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class VeteView
    {
        private VeteController veteController;

        public VeteView()
        {
            veteController = new VeteController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM VETERINÁRIOS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Veterinários");
            Console.WriteLine("2 - Listar Veterinários");
            Console.WriteLine("3 - Exportar Veterinários");
            Console.WriteLine("4 - Importar Veterinários");
            Console.WriteLine("");
            int option = 0;
            option = Convert.ToInt32( Console.ReadLine() );
            switch(option)
            {
                case 1 :
                    Insert();
                break;

                case 2 :
                    List();
                break;

                case 3 :
                    Export();
                break;

                case 4 :
                    Import();
                break;
                default :
                break;
            }
        }

        private void List()
        {
            List<Vete> listagem = veteController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }

        }


        private string Print(Vete vete)
        {
            string retorno = "";
            retorno += $"Id: {vete.Id} \n";
            retorno += $"Nome: {vete.FirstName} {vete.LastName} \n";
            retorno += "-------------------------------------------";
            

            return retorno;
        }
    

        private void Insert()
        {
            Vete vete = new Vete();

            vete.Id = veteController.GetNextId();

            Console.WriteLine("Informe o primeiro nome:");
            vete.FirstName = Console.ReadLine();

            Console.WriteLine("Informe o sobrenome:");
            vete.LastName = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            vete.CPF = Console.ReadLine();

            Console.WriteLine("Informe A especialização:");
            vete.Espec = Console.ReadLine();

            bool retorno = veteController.Insert(vete);

            if( retorno )
                Console.WriteLine("Veterinario inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");

        }
        private void Export()
        {
            if( veteController.ExportToTextFile() )
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Oooops.");
        }

        private void Import()
        {
            if( veteController.ImportFromTxtFile() )
                Console.WriteLine("Dados importado com sucesso!");
            else
                Console.WriteLine("Oooops.");
        }

    }
}