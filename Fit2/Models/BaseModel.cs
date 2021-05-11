using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit2.Models
{
    public interface BaseModel
    {
        ObjectId Id { get; set; }
        string name { get; set; }
    }
}
