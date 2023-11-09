using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace moduloAPI.Entities
{
    public enum TipoConteudo
    {
   
        [Display(Name = "Conteudo")]
        Conteudo,
        [Display(Name = "Atividades")]
        Atividades,
    }
    
}