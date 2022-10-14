using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Event_Management.Models
{
    public class DecorationModel
    {
        public int Dec_id { get; set; }
        public string Dec_Type { get; set; }
        public int Range_of_Guest { get; set; }
        public int Dec_Price { get; set; }
    }
}