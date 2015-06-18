using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fantasias.Data
{
    public class Fantasias
    {
        [Display(Name = "Código Fantasia")]
        public int id_fantasia { get; set; }


        [Display(Name = "Descrição Fantasia")]
        [Required(ErrorMessage = "O campo Nome deve ser preenchido.")]
        public string descricao { get; set; }


        [Display(Name = "Código Categoria")]
        [Required(ErrorMessage = "O campo Telefone deve ser preenchido.")]
        public Categorias id_categoria { get; set; }

    }
}

