using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cel.Modelo.web.Annotations
{
    public class StringEspaçosEmBrancoModelProfile : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return true;//!value.ToString().Contains(" ");
        }
    }
}