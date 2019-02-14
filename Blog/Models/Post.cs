using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [DominioValido]
        [StringLength(50)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Resumo")]
        public string Resumo { get; set; }
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public bool? Publicado { get; set; }
        public Usuario Autor { get; set; }
    }
}
