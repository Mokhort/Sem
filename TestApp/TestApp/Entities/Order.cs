using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        public virtual Good Good { get; set; }
        public DateTime TimeOder { get; set; }
        public int countGood { get; set; }
    }
}
