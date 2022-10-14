using Event_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Event_Management.DBOperation
{
    public class Event_ManagementRep
    {
        Event_ManagementEntities db = new Event_ManagementEntities();
        public List<Customer_EntryModel> ShowRecord()
        {
            using (var db = new Event_ManagementEntities())
            {
                var result = db.Customer_Entry.Select(X => new Customer_EntryModel()
                {
                    Cust_ID = X.Cust_ID,
                    Cust_Name = X.Cust_Name,
                    Address = X.Address,
                    Mobile = X.Mobile,
                    Email = X.Email,
                    Password = X.Password,
                }).ToList();

                return result;
            }
        }
        public List<Book_EventModel> ShowData()
        {
            using (var db = new Event_ManagementEntities())
            {
                var result = db.Book_Event.Select(X => new Book_EventModel()
                {
                    Event_ID = X.Event_ID,
                    Event_Type = X.Event_Type,
                    Venue_Type = X.Venue_Type,
                    No_Of_Guest = X.No_Of_Guest,
                    Booking_Date = X.Booking_Date,
                    Date_of_Availability = X.Date_of_Availability,
                    Event_Time = X.Event_Time,
                    Dec_ID = X.Dec_ID,
                    Dec_Price = X.Dec_Price,
                    Dish_ID = X.Dish_ID,
                    Dish_Price = X.Dish_Price,
                    Item_ID = X.Item_ID,
                    Item_Price = X.Item_Price,
                    Total_Price = X.Total_Price,

                }).ToList();
                return result;
            }
        }
        public void SaveData(Customer_EntryModel model)
        {
            Event_ManagementEntities db = new Event_ManagementEntities();
            Customer_Entry customer = new Customer_Entry();
            customer.Cust_ID = model.Cust_ID;
            customer.Cust_Name = model.Cust_Name;
            customer.Address = model.Address;
            customer.Mobile = model.Mobile;
            customer.Email = model.Email;
            customer.Password = model.Password;

            db.Customer_Entry.Add(customer);
            db.SaveChanges();
        }

        public void Save(Book_EventModel model)
        {
            Book_Event book = new Book_Event();
            book.Event_ID = model.Event_ID;
            book.Event_Type = model.Event_Type;
            book.Venue_Type = model.Venue_Type;
            book.No_Of_Guest = model.No_Of_Guest;
            book.Booking_Date = model.Booking_Date;
            book.Date_of_Availability = model.Date_of_Availability;
            book.Event_Time = model.Event_Time;
            book.Dec_ID = model.Dec_ID;
            book.Dec_Price = model.Dec_Price;
            book.Dish_ID = model.Dish_ID;
            book.Dish_Price = model.Dish_Price;
            book.Item_ID = model.Item_ID;
            book.Item_Price = model.Item_Price;
            book.Total_Price = model.Total_Price;

            db.Book_Event.Add(book);
            db.SaveChanges();
        }

        public List<Decoration> decorationList()
        {
            var decorationList = db.Decorations.ToList();
            return decorationList;
        }
    }
}