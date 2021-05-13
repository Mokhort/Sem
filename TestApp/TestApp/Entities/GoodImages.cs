using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Entities
{
    public class GoodImages
    {
        public int Id { get; set; }
         public string PathsImage { get; set; }
        public virtual Good Good { get; set; }
    }
}
