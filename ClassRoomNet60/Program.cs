// See https://aka.ms/new-console-template for more information


namespace ClassRoomNet60
{
    public class Program
    {
        static void Main(string[]args)
        {
            KlasseRum klasseRum = new KlasseRum();
            klasseRum.KlasseNavn = "3B";
            klasseRum.SemesterStart = new System.DateTime(2022,9,1);
            klasseRum.KlasseListe.Add(new Studerende("Rebekka", 2, 14));
            klasseRum.KlasseListe.Add(new Studerende("Cecilia", 3, 5));
            klasseRum.KlasseListe.Add(new Studerende("Sara", 4, 20));

          

            //print out the information about the students in the class
            foreach (var student in klasseRum.KlasseListe)
            {
                Console.WriteLine($"Navn: {student.Navn}, Fødselsdag: {student.Fødselsdag}, Fødselsmåned: {student.Fødselsmåned}, Årstid: {student.BirthSeason(student.Fødselsmåned)}");
            }
            klasseRum.CountBithSeasons();
        }

    }
}