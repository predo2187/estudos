using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Biblioteca_Jogos_mvc.Models
{
    public class context : DbContext
    {
        public DbSet<jogo> Jogos { get; set; }
    }
}