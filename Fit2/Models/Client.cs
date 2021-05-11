using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit2.Models
{
    public class Client:BaseModel
    {
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string cnp { get; set; }
        public string address { get; set; }
        public string notes { get; set; }

        public bool isDeleted { get; set; }

        public byte[] image { get; set; }

        public string barcode { get; set; }

        public Client()
        {

        }

        public Client(string name, string phone, string email, string cnp, string address, string notes, byte[] image)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.cnp = cnp;
            this.address = address;
            this.notes = notes;
            this.isDeleted = false;
            this.image = image;
            this.barcode = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
