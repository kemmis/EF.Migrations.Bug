using System;
using System.Collections.Generic;
using System.Text;
using Bug.Data.Models.Abstractions;

namespace Bug.Data.Models
{
    public class Car : DataModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public ushort Year { get; set; }
        public ICollection<Tire> Tires { get; set; }
    }
}
