using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Entities
{
    public class Good
    {
        public int Id { get; set; }
        virtual public List<GoodImages> PathsImage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
    }
}
