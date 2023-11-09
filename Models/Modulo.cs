using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static moduloAPI.Entities.Aulas;

namespace moduloAPI.Entities
{
    public class Modulo 

    { 

        [Key] 

        public int IdModulo { get; set; } 

        public string Nome { get; set; } 

        [Required] 

        public int IdCurso { get; set; } 

        [ForeignKey(nameof(IdCurso))] 

        public virtual Cursos Curso { get; set; } 

        public virtual ICollection<Aulas> Aulas { get; set; } 

    } 
}