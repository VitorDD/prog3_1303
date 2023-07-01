using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class AnimalView
    {
        private AnimalController animalController;

        public AnimalView()
        {
            animalController = new AnimalController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM ANIMAIS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Animal");
            Console.WriteLine("2 - Listar Animal");
            Console.WriteLine("3 - Exportar Animal");
            Console.WriteLine("4 - Importar Animal");
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
            List<Animal> listagem = animalController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }

        }

        private string Print(Animal animal)
        {
            string retorno = "";
            retorno += $"Id: {animal.Id} \n";
            retorno += $"Nome: {animal.Name} \n";
            retorno += "-------------------------------------------";
            

            return retorno;
        }
    
        private void Insert()
        {
            Animal animal = new Animal();

            animal.Id = animalController.GetNextId();

            Console.WriteLine("Informe o nome:");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Informe a raça:");
            animal.Raça = Console.ReadLine();

            Console.WriteLine("Informe o tipo:");
            animal.Tipo = Console.ReadLine();

            bool retorno = animalController.Insert(animal);

            if( retorno )
                Console.WriteLine("Animal inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");

        }

        private void Export()
        {
            if( animalController.ExportToTextFile() )
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Oooops.");
        }

        private void Import()
        {
            if( animalController.ImportFromTxtFile() )
                Console.WriteLine("Dados importado com sucesso!");
            else
                Console.WriteLine("Oooops.");
        }

    }
}