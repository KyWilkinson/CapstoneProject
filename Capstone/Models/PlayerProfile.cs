using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class PlayerProfile
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Sports Played" )]
        public string sportsPlayed { get; set; }

        [Display(Name = "City")]
        public string location { get; set; }

        [Display(Name = "Review")]
        public string playerReview { get; set; }

        [ForeignKey("Team")]
        public int? TeamId { get; set; }
        public Team team { get; set; }
    }
}
