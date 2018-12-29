using System;
using System.Collections.Generic;
using System.Text;
using Bug.Data.Models.Abstractions;

namespace Bug.Data.Models
{
    public class Race : DataModel
    {
        public DateTime DateTime { get; set; }
        public String Name { get; set; }
        public ICollection<RaceDriver> RaceDrivers { get; set; }
    }
}
