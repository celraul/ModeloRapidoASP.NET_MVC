using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cel.Modelo.web.ViewModels
{
    public class EmpresaViewModel
    {
        [Key]
        public int IdEmpresa { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Fantasia")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {0} caracteres")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Preencha o campo Razão Social")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {0} caracteres")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ ")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(14, ErrorMessage = "Minimo {0} caracteres")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-Mail ")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(14, ErrorMessage = "Minimo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail valido")]
        [DisplayName("E-Mail")]
        public string Email { get; set; }

        //[ScaffoldColumn(false)]
        // [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        // public DateTime DataCriacao { get; set; }

        // public virtual IEnumerable<UsuarioViewModel> Usuarios { get; set; }
    }
}