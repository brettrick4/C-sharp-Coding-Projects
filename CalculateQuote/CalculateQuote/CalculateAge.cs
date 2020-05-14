using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateQuote
{
    public abstract class CalculateAge
    {
        public DateTime Now  { get; }
        public int Year { get; }
        public int Y { get; set; }
    }
}
