using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Models
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:50)]
        public string Name { get; set; }

        public virtual Team CoachTeam { get; set; }

    }
}
