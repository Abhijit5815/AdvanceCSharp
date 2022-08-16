using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Ticket : IEquatable<Ticket>
    {
        //property to store the duration of ticket in hours

        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        { 
            DurationInHours = durationInHours; 
        }

        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours; 
        }
    }
}
