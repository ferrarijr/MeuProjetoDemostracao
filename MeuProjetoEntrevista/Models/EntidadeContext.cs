using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MeuProjetoEntrevista.Models
{
    public class EntidadeContext :DbContext
    {
        public EntidadeContext() : base("Entidade")
        {
            Database.CreateIfNotExists();  
        }
        public DbSet <Pessoa> Pessoas { get; set; }
    }
}