using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Entidades
{
    public class Feed
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool Visualizado { get; set; }
        public int NumeroVisualizacoes { get; set; }
        public int UsuarioCriacaoId { get; set; }
        public virtual Usuario UsuarioCriacao { get; set; }
       
    }
}
