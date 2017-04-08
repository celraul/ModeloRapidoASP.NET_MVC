using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cel.Modelo.web.ViewModels
{
    public class AlbumViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome Album")]
        public string Nome { get; set; }

        [DisplayName("Album Ano")]
        public int Ano { get; set; }

        [DisplayName("Observações")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        public string Observacoes { get; set; }
        public string Email { get; set; }
    }
}