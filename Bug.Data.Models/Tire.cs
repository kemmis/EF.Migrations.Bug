using System;
using System.Collections.Generic;
using System.Text;
using Bug.Data.Models.Abstractions;

namespace Bug.Data.Models
{
    public class Tire : DataModel
    {
        public string Make { get; set; }
        public int Size { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}
