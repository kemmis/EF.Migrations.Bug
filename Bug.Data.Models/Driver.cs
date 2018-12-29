using System;
using System.Collections.Generic;
using System.Text;
using Bug.Data.Models.Abstractions;

namespace Bug.Data.Models
{
    public class Driver : DataModel
    {
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public ICollection<RaceDriver> RaceDrivers { get; set; }
    }
}
