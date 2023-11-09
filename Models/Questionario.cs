using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace moduloAPI.Entities
{
    public class Questionario
    {
       

        [Key] 

        public int IdQuestionario { get; set; } 

        public string UploadImagem { get; set; } 

        public string Enunciado{ get; set; } 

        public string OpcaoUm{ get; set; } 

        public string OpcaoDois{ get; set; } 

        public string OpcaoTres { get; set; } 

        public string OpcaoQuatro { get; set; } 

        public string OpcaoCinco { get; set; } 

        public int RespostaCorreta { get; set; } 

        public int IdQuestionManager { get; set; } 

        [ForeignKey (nameof(IdQuestionManager))] 

        public virtual QuestionarioManager QuestionarioManager { get; set; } 

    }
    
}