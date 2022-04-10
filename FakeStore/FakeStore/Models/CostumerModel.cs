using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeStore.Models
{

    public class CostumerModel
    {
        public int CostumerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime costumerSince { get; set; }
        public bool IsActive { get; set; }
    }
}