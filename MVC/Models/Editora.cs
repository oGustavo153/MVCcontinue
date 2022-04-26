using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Editora
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        public string CNPJ { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? AnoFundacao { get; set; }

    }
}
