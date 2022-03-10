using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concert_Tracker.Models
{
    public class Band
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
        public string Genre { get; set; } = string.Empty;
        public List<string> Members { get; set; }

    }
}
