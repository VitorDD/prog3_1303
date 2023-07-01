using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Models;
using Arquivos.Data;

namespace Arquivos.Controllers
{
    public class ClinicController
    {
        private string directoryName = "ReportFiles";
        private string fileName =  "Clinica.txt";
        public List<Clinic> List()
        {
            return DataSet.Clinics;
        }

        public bool Insert(Clinic clinic)
        {
            if( clinic == null )
                return false;

            if( clinic.Id <= 0 )
                return false;

            if( string.IsNullOrWhiteSpace(clinic.ClinicName) )
                return false;

            DataSet.Clinics.Add(clinic);

            return true;
        }
        
        public bool ExportToTextFile()
        {
            if(!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);

            string fileContent = string.Empty;
            foreach(Clinic cl in DataSet.Clinics)
            {
                fileContent += $"{cl.Id};{cl.ClinicName};{cl.Endereço};{cl.Telefone}";   
                fileContent += "\n";
            }

            try
            {
            StreamWriter sw = File.CreateText( $"{directoryName}\\{fileName}" );

            sw.Write(fileContent);
            sw.Close();
            }
            catch (IOException ioEx)
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
                    Clinic clinic = new Clinic();
                    string[] clinicData = line.Split(';');
                    clinic.Id = Convert.ToInt32 ( clinicData[0] );
                    clinic.ClinicName = clinicData[1];
                    clinic.Endereço = clinicData[2];
                    clinic.Telefone = clinicData[3];

                    DataSet.Clinics.Add(clinic);

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
            int tam = DataSet.Clinics.Count;

            if( tam > 0 )
                return DataSet.Clinics[tam - 1].Id + 1;
            else
                return 1;
        }

    }
}