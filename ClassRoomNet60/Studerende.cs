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

        public int fødselsmåned
        {
            get { return Fødselsmåned; }
            set
            {
                if (value >= 1 && value <= 12)
                    fødselsmåned = value;
                else
                    throw new ArgumentOutOfRangeException($"Fødselsmåned skal være mellem 1 og 12, du skrev {value}");


            }
        }
        //Constructor
        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            
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

        public override string ToString()
        {
            return $"Navn: {Navn}, Fødselsdag: {Fødselsdag}, Fødselsmåned: {Fødselsmåned}, Årstid: {BirthSeason(Fødselsmåned)}";
        }



    }
}
