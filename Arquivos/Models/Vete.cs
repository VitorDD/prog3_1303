using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{ 
    public class Vete
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CPF { get; set; }
        public string? Espec { get; set; }

        public Vete()
        {

        }
       
        public Vete(
            int id
            , string? firstName
            , string? lastName
            , string? cPF
            , string? espec
        )
        { 
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            Espec = espec;
        }
    } 
} 