using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class KlasseRum
    {
        //Properties
        public string KlasseNavn { get; set; }
        public List<Studerende> KlasseListe { get; set; }
        public DateTime SemesterStart { get; set; }

        //Constructor
        public KlasseRum()
        {
            KlasseNavn = "Unknown";
            KlasseListe = new List<Studerende>();
            SemesterStart = DateTime.Now;
        }
        //Method to count the number of students born in each season
        public void CountBithSeasons() //Count the number of students born in each season
        {
            var seasonCount = KlasseListe.GroupBy(s => s.BirthSeason(s.Fødselsmåned)).Select(g => new { Season = g.Key, Count = g.Count() }); //Group the students by season and count the number of students in each season
            foreach (var season in seasonCount)
            {
                Console.WriteLine($"Season: {season.Season}, Count: {season.Count}");
            }

        }
    }
}
