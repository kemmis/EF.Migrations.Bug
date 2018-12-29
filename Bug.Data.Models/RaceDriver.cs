using System;
using System.Collections.Generic;
using System.Text;
using Bug.Data.Models.Abstractions;

namespace Bug.Data.Models
{
    public class RaceDriver
    {
        public Race Race { get; set; }
        public int RaceId { get; set; }
        public Driver Driver { get; set; }
        public int DriverId { get; set; }
    }
}
