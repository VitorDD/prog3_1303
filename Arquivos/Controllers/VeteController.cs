using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class VeteController
    {
        private string directoryName = "ReportFiles";
        private string fileName = "Veterinarios.txt";
        public List<Vete> List()
        {
            return DataSet.Vetes;
        }


        public bool Insert(Vete vete)
        {
            if( vete == null )
                return false;

            if( vete.Id <= 0 )
                return false;

            if( string.IsNullOrWhiteSpace(vete.FirstName) )
                return false;

            DataSet.Vetes.Add(vete);

            return true;
        }

        public bool ExportToTextFile()
        {
            if(!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);

            string fileContent = string.Empty;
            foreach(Vete v in DataSet.Vetes)
            {
              fileContent += $"{v.Id};{v.CPF};{v.FirstName};{v.LastName};{v.Espec}";   
              fileContent += "\n";
            }

            try
            {
            StreamWriter sw = File.CreateText( $"{directoryName}\\{fileName}" );

            sw.Write(fileContent);
            sw.Close();
            }
            catch(IOException ioEx)
            {
                Console.WriteLine("Erro ao manipular o arquivo.");
                Console.WriteLine(ioEx.Message);
                return false;
            }

            return true;
        }



        public bool ImportFromTxtFile()
        {
            try
            {
                StreamReader sr = new StreamReader( $"{directoryName}\\{fileName}" );

                string line = string.Empty;
                line = sr.ReadLine();
                while( line != null )
                {
                    Vete vete = new Vete();
                    string[] veteData = line.Split(';');
                    vete.Id = Convert.ToInt32 ( veteData[0] );
                    vete.CPF = veteData[1];
                    vete.FirstName = veteData[2];
                    vete.LastName = veteData[3];
                    vete.Espec = veteData[4];

                    DataSet.Vetes.Add(vete);

                    line = sr.ReadLine();
                } 

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ooops. Ocorreu um erro ao tentar importar os dados.");
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public int GetNextId()
        {
            int tam = DataSet.Vetes.Count;

            if( tam > 0 )
                return DataSet.Vetes[tam - 1].Id + 1;
            else
                return 1;
        }
    }
}