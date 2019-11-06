using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1_123123123.Models
{
    public class PetFood
    {
        public virtual int Id { get; set; }

        public virtual Decimal Price { get; set; }
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual String NutritionalInfo { get; set; }
        public virtual float Weight { get; set; }
        public virtual String Brand { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual int AnimalId { get; set; }
    }
}
