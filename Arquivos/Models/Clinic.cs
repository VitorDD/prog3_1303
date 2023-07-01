using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string? ClinicName { get; set; }
        public string? Endereço { get; set; }
        public string? Telefone { get; set; }

        public Clinic()
        {

        }
       
        public Clinic(
            int id
            , string? clinicName
            , string? endereço
            , string? telefone
        )
        { 
            Id = id;
            ClinicName = clinicName;
            Endereço = endereço;
            Telefone = telefone;
        }
    }
}