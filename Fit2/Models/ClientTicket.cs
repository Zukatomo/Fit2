using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit2.Models
{
    public class ClientTicket
    {
        public ObjectId Id { get; set; }
        public ObjectId clientId { get; set; }
        public ObjectId ticketTypeId { get; set; }
        public BsonDateTime buyDate { get; set; }
        public BsonDateTime firstUseDate { get; set; }
        public int used { get; set; }

        public ClientTicket()
        {
        }

        public ClientTicket(ObjectId clientId, ObjectId ticketTypeId)
        {
            this.clientId = clientId;
            this.ticketTypeId = ticketTypeId;
            this.buyDate = DateTime.Now;
            this.firstUseDate = null;
            this.used = 0;
        }
    }
}
