using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1_123123123.Models
{
    public class Animal
    {
        public virtual int Id { get; set; }
        [Required]
        public virtual String Name { get; set; }
        [Required]
        public virtual String Description { get; set; }
        public virtual List<PetFood> PetFoods { get; set; }
    }
}
