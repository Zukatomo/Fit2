using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit2.Models
{
    class TicketType
    {
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int days { get; set; }
        public int occasion { get; set; }
        public bool isDeleted { get; set; }
        public int roomId { get; set; }
        public int startTime { get; set; }
        public int endTIme { get; set; }
        public int maxOccasionPerDay { get; set; }

        public TicketType()
        {
        }

        public TicketType(string name, double price, int days, int occasion, bool isDeleted, int roomId, int startTime, int endTIme, int maxOccasionPerDay)
        {
            this.name = name;
            this.price = price;
            this.days = days;
            this.occasion = occasion;
            this.isDeleted = isDeleted;
            this.roomId = roomId;
            this.startTime = startTime;
            this.endTIme = endTIme;
            this.maxOccasionPerDay = maxOccasionPerDay;
        }
    }
}
