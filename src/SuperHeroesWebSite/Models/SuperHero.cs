using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroesWebSite.Models
{
    public class SuperHero
    {
        [Required]
        public int ID { get; set; }
        [StringLength(200)]
        [Required]
        public string Name { get; set; }        
        public string ImageUri { get; set; }

    }
}