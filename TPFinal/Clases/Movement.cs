using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Movement
    {
        public string date { get; set; }
        public float amount { get; set; }

        public Movement(string pDate, float pAmount)
        {
            this.date = pDate;
            this.amount = pAmount;
        }
    }
}
