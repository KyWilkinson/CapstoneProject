using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Team Name")]
        public string teamName { get; set; }

        [ForeignKey("Players")]
        public int? playerId { get; set; }
        public PlayerProfile playerProfile { get; set; }

        [ForeignKey("Owner")]
        public int? ownerId { get; set; }
        public Owner owner { get; set; }
    }
}
