using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cel.Modelo.web.Annotations
{
    public class EmailPersonalizadoModelProfile : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith("@cel.com.br");
        }
    }
}