using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class ClinicView
    {
        private ClinicController clinicController;

        public ClinicView()
        {
            clinicController = new ClinicController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM CLINICA");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Clinica");
            Console.WriteLine("2 - Listar Clinica");
            Console.WriteLine("3 - Exportar Clinica");
            Console.WriteLine("4 - Importar Clinica");
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
            List<Clinic> listagem = clinicController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }

        }


        private string Print(Clinic clinic)
        {
            string retorno = "";
            retorno += $"Id: {clinic.Id} \n";
            retorno += $"Nome: {clinic.ClinicName}\n";
            retorno += "-------------------------------------------";
            

            return retorno;
        }
    

        private void Insert()
        {
            Clinic clinic = new Clinic();

            clinic.Id = clinicController.GetNextId();

            Console.WriteLine("Informe o nome:");
            clinic.ClinicName = Console.ReadLine();

            Console.WriteLine("Informe o Endereço:");
            clinic.Endereço = Console.ReadLine();

            Console.WriteLine("Informe o Telefone:");
            clinic.Telefone = Console.ReadLine();

            bool retorno = clinicController.Insert(clinic);

            if( retorno )
                Console.WriteLine("Clinica inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");

        }
        private void Export()
        {
            if( clinicController.ExportToTextFile() )
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Oooops.");
        }

        private void Import()
        {
            if( clinicController.ImportFromTxtFile() )
                Console.WriteLine("Dados importado com sucesso!");
            else
                Console.WriteLine("Oooops.");
        }
    }
}