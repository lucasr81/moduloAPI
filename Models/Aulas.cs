using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static moduloAPI.Conteudo;

namespace moduloAPI.Entities;

    public class Aulas
    {
     

        [Key] 

        public int IdAula { get; set; } 

        public TipoConteudo Tipo { get; set; } 

        [Required] 

        public int IdModulo { get; set; } 

        [ForeignKey("IdModulo")] 

        public virtual Modulo Modulo { get; set; } 

    }

