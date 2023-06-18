using SinemaTicketSalesAutomation.Enum;
using SinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaTicketSalesAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {

            string basePath = "C:\\Users\\mehme\\OneDrive\\Masaüstü\\C#\\Windows Form App\\SinemaTicketSalesAutomation\\SinemaTicketSalesAutomation\\Picture\\";

            return new List<Movie>()
            {
             new Movie() {
             movieName ="Bean",
             category =Category.komedi,
             minute="1 saat 30 dakika",
             price =50,
             
             //sessions default olarak verildi
             picturePath =basePath+"Komedi.png"

             },
             new Movie()
             {
             movieName ="It",
             category =Category.gerilim,
             minute="2 saat 12 dakika",
             price =50,
             //sessions default olarak verildi
             picturePath =basePath+"Gerilim.png"
             },
              new Movie()
             {
             movieName ="Yenilmezler and Game",
             category =Category.macera,
             minute="3 saat 0 dakika",
             price =50,
             //sessions default olarak verildi
             picturePath =basePath+"Macera.png"
             },
               new Movie()
             {
             movieName ="Star Wars the last Jedi",
             category =Category.fantastik,
             minute="2 saat 32 dakika",
             price =50,
             //sessions default olarak verildi
             picturePath =basePath+"Fantastik.png"
             },
                new Movie()
             {
             movieName ="Alian",
             category =Category.bilim_kurgu,
             minute="2 saat 2 dakika",
             price =20,
             //sessions default olarak verildi
             picturePath =basePath+"BilimKurgu.png"
             },
            new Movie()
             {
             movieName ="Evdeki düşman",
             category =Category.gerilim,
             minute="2 saat 2 dakika",
             price =30,
             //sessions default olarak verildi
             picturePath =basePath+"Korku.png"
             },

            };//Object initilazer
        }
    }
}
