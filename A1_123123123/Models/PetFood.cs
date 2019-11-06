using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1_123123123.Models
{
    public class PetFood
    {
        //Tables need a primary key
        public virtual int Id { get; set; }

        //price must be entered to be valid
        [Required]
        public virtual Decimal Price { get; set; }
        [Required]
        public virtual String Name { get; set; }
        [Required]
        public virtual String Description { get; set; }
        [Required]
        public virtual String NutritionalInfo { get; set; }
        [Required]
        public virtual float Weight { get; set; }
        [Required]
        public virtual String Brand { get; set; }
        //foreign key relationship with Animal
        [Required]
        public virtual Animal Animal { get; set; } //navigational property
        public virtual int AnimalId { get; set; } //fkey id
    }
}
