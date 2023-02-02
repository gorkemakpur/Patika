using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_BoardApplication.Data
{
    public class Card
    {
        public String Title { get; set; }
        public String Content { get; set; }
        public String Member { get; set; }
        public String Size { get; set; }
        public string Line { get; set; } = "TODO";
    }
}
