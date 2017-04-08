using Cel.Modelo.web.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Cel.Modelo.web.ViewModels
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(4, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome do usuário")]
        [DisplayName("Nome Usuário")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(4, ErrorMessage = "Minimo {0} caracteres")]
        [StringEspaçosEmBrancoModelProfile(ErrorMessage = "Nome de usúario não pode conter espaços")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [DisplayName("Senha")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Minimo {0} caracteres")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar a senha")]
        [Compare("Password", ErrorMessage = "A senhe e a confirmação da senha são diferentes")]
        [NotMapped]
        public string ConfirmaPassword { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail ")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail valido")]
        [DisplayName("E-Mail")]
        //[EmailPersonalizadoModelProfile(ErrorMessage = " E-mail tem que ser da companhia")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DataCriacao { get; set; }
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Preencha o campo empresa")]
        public int IdEmpresa { get; set; }

        //  public virtual EmpresaViewModel Empresa { get; set; }
        //public virtual Empresa empresa { get; set; }
    }
}