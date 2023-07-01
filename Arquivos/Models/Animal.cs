using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Animal
    { 
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Raça { get; set; }
        public string? Tipo { get; set; }

        public Animal()
        {

        }
        
        public Animal(
            int id
            , string? name
            , string? raça
            , string? tipo
        )
        { 
            Id = id;
            Name = name;
            Raça = raça;
            Tipo = tipo;
        }
    } 
} 