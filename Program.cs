using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            //We are able to comapre two objects

            Console.WriteLine(t2.Equals(t1));
            //.Equals will work even if comment out equal method in ticket class but we want to compare objects based upon
            //duration hence we created our own method using the IEquatable
        }
    }
}
