using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Fantasias.Data
{
    public class Exemplares
    {
        [Display (Name = "ID do exemplar:")]
        public int id_exemplar { get; set; }

        [Display(Name = "ID da fantasia:")]
        public int id_fantasia { get; set; }


         [Display(Name = "Tamanho da fantasia:")]
        public string tamanho { get; set; }


    }
}
