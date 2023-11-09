using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace moduloAPI.Entities
{
    public class Cursos
    {
         [Key] 
          public int IdCurso { get; set; } 

    public string Nome { get; set; } 

    public string Descricao { get; set; } 

    public double Preco { get; set; } 

    public string Categoria { get; set; } 

    public string Instrutor { get; set; }
    }
}