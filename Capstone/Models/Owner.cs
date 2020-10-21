using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Team Name")]
        public string teamOwned { get; set; }

        [ForeignKey("Player Profile")]
        public int? playerId { get; set; }
        public PlayerProfile profile { get; set; }
    }
}
