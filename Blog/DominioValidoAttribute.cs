using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog
{
    public class DominioValidoAttribute : ValidationAttribute
    {
        public DominioValidoAttribute() : base("Não pode ter rambo!")
        {

        }

        public override bool IsValid(object value)
        {
            string Titulo = value.ToString();
            bool dominio = !Titulo.Contains("Rambo");
            return dominio;
        }
    }
}
