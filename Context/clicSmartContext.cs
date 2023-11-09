using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moduloAPI.Entities;

namespace moduloAPI.Context
{
    public class clicSmartContext : DbContext
    {
        public clicSmartContext(DbContextOptions<clicSmartContext> options) : base(options)
        {

        }
        public DbSet<Aulas> Aulas { get; set; }
        //public DbSet<Conteudo> Conteudo { get; set; }
        
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<Questionario> Questionario { get; set; }
        public DbSet<QuestionarioManager> QuestionarioManager { get; set; }
        
    }
}
