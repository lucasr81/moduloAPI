using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace moduloAPI.Entities
{
    public class Conteudo
    {
   
        [Key] 

        public int IdConteudo { get; set; } 

        public string Upload { get; set; } 

        public int IdModulo { get; set; } 

        [ForeignKey (nameof(IdModulo))] 

        public virtual Modulo Modulo { get; set; } 

    } 
    
}