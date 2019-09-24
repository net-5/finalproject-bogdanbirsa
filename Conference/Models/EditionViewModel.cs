using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Models
{
    public class EditionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TagLine { get; set; }
        [Required]
        [Range (1986,2019)]
        public int Year { get; set; }
        public bool Active { get; set; }

    }
}
