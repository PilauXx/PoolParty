using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolParty.Models
{
    public class Licensie
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public int Age { get; set; }

        public ICollection<Equipe> Equipes { get; set; }
    }
}
