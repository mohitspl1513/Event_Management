using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Event_Management.Models
{
    public class Book_EventModel
    {
        public int Event_ID { get; set; }
        public string Event_Type { get; set; }
        public string Venue_Type { get; set; }
        public int No_Of_Guest { get; set; }
        public System.DateTime Booking_Date { get; set; }
        public string Date_of_Availability { get; set; }
        public string Event_Time { get; set; }
        public int Dec_ID { get; set; }
        public int Dec_Price { get; set; }
        public int Dish_ID { get; set; }
        public int Dish_Price { get; set; }
        public int Item_ID { get; set; }
        public int Item_Price { get; set; }
        public int Total_Price { get; set; }

        public virtual ADD_ON_ITEM ADD_ON_ITEM { get; set; }
        public virtual Decoration Decoration { get; set; }
        public virtual Food Food { get; set; }
    }
}