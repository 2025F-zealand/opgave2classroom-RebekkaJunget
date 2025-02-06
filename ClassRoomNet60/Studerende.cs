using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Studerende
    {
        //
        public string Navn { get; set; }
        public int Fødselsmåned { get; set; }
        public int Fødselsdag { get; set; }

        //Constructor
        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            if (Fødselsmåned < 1 || Fødselsmåned > 12)
            {
                throw new ArgumentOutOfRangeException("Fødselsmåned skal være mellem 1 og 12");
            }
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }

        //Method to determine the season of the birth month
        public string BirthSeason(int fødselsmåned) 
        {
             
            if (Fødselsmåned == 12 || Fødselsmåned == 1 || Fødselsmåned == 2)
            {
                return "Winter";
            }
            else if (Fødselsmåned == 3 || Fødselsmåned == 4 || Fødselsmåned == 5)
            {
                return "Spring";
            }
            else if (Fødselsmåned == 6 || Fødselsmåned == 7 || Fødselsmåned == 8)
            {
                return "Summer";
            }
            else if (Fødselsmåned == 9 || Fødselsmåned == 10 || Fødselsmåned == 11)
            {
                return "Autumn";
            }
            return null;


        }

        //Method to check if the birth day is between 1 and 31
        public Exception BirthDayException(int fødselsdag) 
        {
            if (Fødselsdag < 1 || Fødselsdag > 31)
            {
                throw new ArgumentOutOfRangeException("Fødselsdag skal være mellem 1 og 31");
            }
            return null;
        }
        //Method to check if the birth month is between 1 and 12
        public Exception BirthMonthException(int fødselsmåned)
        {
       
            return null;
        }



    }
}
