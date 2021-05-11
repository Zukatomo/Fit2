using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit2.Models
{
    public class Admission
    {
        public ObjectId Id { get; set; }
        public ObjectId clientTicketId { get; set; }
        public ObjectId userId { get; set; }
        public BsonDateTime date { get; set; }

        public Admission()
        {
        }

        public Admission(ObjectId clientTicketId, ObjectId userId)
        {
            this.clientTicketId = clientTicketId;
            this.userId = userId;
            this.date = DateTime.Now;
        }
    }
    

}
