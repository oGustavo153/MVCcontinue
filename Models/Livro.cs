using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Livro
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataPublicacao { get; set; }
    }
}
