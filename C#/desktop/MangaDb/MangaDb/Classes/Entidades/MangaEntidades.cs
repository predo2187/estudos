using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaDb.Classes.Entidades
{
    public class MangaEntidades
    {
        public int id { get; set; }
        public string nome1 { get; set; }
        public string nome2 { get; set; }
        public char completo { get; set; }
        public char dropado { get; set; }
        public char iato { get; set; }
        public char cancelado { get; set; }
        public double preco { get; set; }
        public int volumes { get; set; }
        public int idAutor { get; set; }
        public int idMangaka { get; set; }
        public int idGenero1 { get; set; }
        public int idGenero2 { get; set; }
        public int idEditora{ get; set; }





        public string imagem { get; set; }

    }
}
