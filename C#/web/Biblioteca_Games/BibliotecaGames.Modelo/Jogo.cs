using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.Entidades 
{
    public class Jogo : IntId
    {
        public int Id { get; set; }
        public double ? valorPago { get; set; }
        public string Imagem { get; set; }
        public  DateTime /*permite valor nulo*/? DataCompra { get; set; }
        public string Titulo { get; set; }
        public int idGenero { get; set; }
        public Genero genero { get; set; }
        public int idEditor { get; set; }
        public Editor editor { get; set; }
    }

}
