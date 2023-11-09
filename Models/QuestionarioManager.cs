using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace moduloAPI.Entities
{
    public class QuestionarioManager
    {
    

        [Key] 

        public int IdQuestionManager { get; set; } 

        public bool LiberarQuestao { get; set; } 

        public int IdModulo { get; set; } 

        [ForeignKey (nameof(IdModulo))] 

        public virtual Modulo Modulo { get; set; } 

    } 
    
}