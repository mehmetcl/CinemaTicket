using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaTicketSalesAutomation.Models
{
    public class Chair
    {
        public Chair(string _row, string _number)
        {
            row = _row;
            number = _number;

        }
        public string row { get; set; } //A B C D 
        public string number { get; set; }// 1 2 4 5 6 
        public bool status { get; set; }
    }
}
