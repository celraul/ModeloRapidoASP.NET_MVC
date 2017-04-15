using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cel.Modelo.web.ViewModels
{
    public class FeedViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Texto { get; set; }

        public bool Visualizado { get; set; }

        public int NumeroVisualizacoes { get; set; }

        public int UsuarioCriacaoId { get; set; }
        public virtual UsuarioViewModel UsuarioCriacao { get; set; }

        public DateTime? DataCriacao { get; set; }
    }
}