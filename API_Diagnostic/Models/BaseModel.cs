using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Diagnostic.Models
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
    }
}