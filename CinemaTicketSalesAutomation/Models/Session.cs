using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaTicketSalesAutomation.Models
{
    public class Session
    {
        public Session()
        {
            SetDefaultChairs();
        }

        public string date { get; set; }
        public string time { get; set; }
        public List<Chair> chairs { get; set; }

        private void SetDefaultChairs() 
        {
            chairs = new List<Chair>();
            string[] rows = {"a","b","c","d" };
            string[] numbers = { "1", "2", "3","4","5","6" };

            foreach (string row in rows) {
                foreach (string number in numbers)
                {
                    Chair chair =new Chair(row,number);//A1 A2 A3...B1 B2 B3 ...
                    chairs.Add(chair);
                }
            }
        }
    }
}