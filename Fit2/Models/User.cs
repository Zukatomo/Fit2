using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit2.Models
{
    public class User: BaseModel
    {
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }
    }
}
