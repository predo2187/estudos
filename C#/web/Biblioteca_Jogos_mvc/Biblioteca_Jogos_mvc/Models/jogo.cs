using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca_Jogos_mvc.Models
{
    public class jogo
    {
        [Key]
        public int idJogo { get; set; }
        public string nomeJogo { get; set; }
        public double precoJogo { get; set; }
        public string generoJogo { get; set; }
        public DateTime dataCompra { get; set; }

    }
}